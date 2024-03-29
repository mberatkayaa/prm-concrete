﻿using Extensions;
using RemoteVariableHandler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Binding;

namespace Promax.Core
{
    public static class ExtensionMethods
    {
        public static List<string> Vars = new List<string>();
        public static List<string> Params = new List<string>();
        public static BindingHandler BindDefault(this IVariableOwner owner, IVariables variableScope, MyBinding binding)
        {
            BindingHandler result = null;
            var properties = owner.Variables;
            if (string.IsNullOrEmpty(owner.VariableOwnerName))
                return result;
            foreach (var propertyName in properties)
            {
                object obj = owner;
                Vars.Add(owner.VariableOwnerName + "_" + propertyName);

                variableScope.GetAs<IConvertibleRemoteValue>(owner.VariableOwnerName, propertyName).Do(x =>
                {
                    var bindingHandler = binding.CreateBinding().Source(obj).SourceProperty(propertyName).
                    Target(x).TargetProperty(nameof(IConvertibleRemoteValue.ConvertedReadValue)).
                    Mode(MyBindingMode.OneWayToSource).Convert(owner.GetConverterForVariable(propertyName));
                    bindingHandler.InitialMapping();
                    result = bindingHandler;
                });

                variableScope.GetValue(owner.VariableOwnerName, propertyName).Do(x =>
                {
                    var bindingHandler = binding.CreateBinding().Source(obj).SourceProperty(propertyName).
                    Target(x).TargetProperty(nameof(IRemoteValue.ReadValue)).
                    Mode(MyBindingMode.OneWayToSource).Convert(owner.GetConverterForVariable(propertyName));
                    bindingHandler.InitialMapping();
                    result = bindingHandler;
                });
            }
            if (owner is IDirectedPropertyOwner)
            {
                var obj = owner as IDirectedPropertyOwner;
                foreach (var property in obj.DirectedProperties)
                {
                    foreach (var directedProperty in property.Value)
                    {
                        Vars.Add(owner.VariableOwnerName + "_" + property.Key);

                        variableScope.GetAs<IConvertibleRemoteValue>(owner.VariableOwnerName, property.Key).Do(x =>
                        {
                            var bindingHandler = binding.CreateBinding().Source(obj).SourceProperty(directedProperty).
                            Target(x).TargetProperty(nameof(IConvertibleRemoteValue.ConvertedReadValue)).
                            Mode(MyBindingMode.OneWayToSource).Convert(owner.GetConverterForVariable(directedProperty));
                            bindingHandler.InitialMapping();
                            result = bindingHandler;
                        });

                        variableScope.GetValue(owner.VariableOwnerName, property.Key).Do(x =>
                        {
                            var bindingHandler = binding.CreateBinding().Source(obj).SourceProperty(directedProperty).
                            Target(x).TargetProperty(nameof(IRemoteValue.ReadValue)).
                            Mode(MyBindingMode.OneWayToSource).Convert(owner.GetConverterForVariable(directedProperty));
                            bindingHandler.InitialMapping();
                            result = bindingHandler;
                        });
                    }
                }
            }
            return result;
        }
        public static void BindDefault(this IParameterOwner owner, ParameterOwnerContext parameterOwnerContext, MyBinding binding)
        {
            var properties = owner.Parameters;
            if (string.IsNullOrEmpty(owner.ParameterOwnerName))
                return;
            foreach (var property in properties)
            {
                object obj = owner;
                parameterOwnerContext.ParameterOwners.FirstOrDefault(x => x.Name.IsEqual(owner.ParameterOwnerName)).
                    Do(parameterOwner =>
                    {
                        parameterOwner.Parameters.ForEach(q => Params.Add(parameterOwner.Name + "_" + q.Code));
                        parameterOwner.Parameters.FirstOrDefault(parameter => parameter.Code.IsEqual(property)).Do(parameter =>
                        {
                            var bindingHandler = binding.CreateBinding().Target(obj).TargetProperty(property).
                            Source(parameter).SourceProperty(nameof(IParameter.Value)).Mode(MyBindingMode.TwoWay).Convert(owner.GetConverterForVariable(property));
                            bindingHandler.InitialMapping();
                        });
                    });
            }
            if (owner is IDirectedPropertyOwner)
            {
                var obj = owner as IDirectedPropertyOwner;
                foreach (var property in obj.DirectedProperties)
                {
                    foreach (var directedProperty in property.Value)
                    {
                        parameterOwnerContext.ParameterOwners.FirstOrDefault(x => x.Name.IsEqual(owner.ParameterOwnerName)).
                            Do(parameterOwner =>
                            {
                                parameterOwner.Parameters.ForEach(q => Params.Add(parameterOwner.Name + "_" + q.Code));
                                parameterOwner.Parameters.FirstOrDefault(parameter => parameter.Code.IsEqual(property.Key)).Do(parameter =>
                                {
                                    var bindingHandler = binding.CreateBinding().Target(obj).TargetProperty(directedProperty).
                                    Source(parameter).SourceProperty(nameof(IParameter.Value)).Mode(MyBindingMode.TwoWay).Convert(owner.GetConverterForVariable(directedProperty));
                                    bindingHandler.InitialMapping();
                                });
                            });
                    }
                }
            }
        }
        public static void Write(this IRemoteVariable var, IVariableCommunicator communicator)
        {
            if (var != null && communicator != null)
            {
                communicator.Write(var);
            }
        }
        public static void Write(this IConvertibleRemoteVariable var, IVariableCommunicator communicator)
        {
            var.Do(x => x.RemoteVariable.Do(y => y.Write(communicator)));
        }
        public static void Write(this IRemoteVariable var)
        {
            if (var != null && var.Communicator != null)
            {
                var.Communicator.Write(var);
            }
        }
        public static void Write(this IConvertibleRemoteVariable var)
        {
            var.Do(x => x.RemoteVariable.Do(y => y.Communicator.Write(y)));
        }
        public static void Read(this IRemoteVariable var, IVariableCommunicator communicator)
        {
            if (var != null && communicator != null)
            {
                communicator.Read(var);
            }
        }
        public static void Read(this IConvertibleRemoteVariable var, IVariableCommunicator communicator)
        {
            var.Do(x => x.RemoteVariable.Do(y => communicator.Read(y)));
        }
        /// <summary>
        /// Değeri scale değerine göre shorta çevirir.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static short Scalify(this double value, int scale)
        {
            return Convert.ToInt16(Math.Pow(10, scale) * value);
        }
        /// <summary>
        /// Değeri scale değerine göre böler.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static double Descalify(this double value, int scale)
        {
            var a = Math.Pow(10, scale);
            return value / a;
        }
    }
}
