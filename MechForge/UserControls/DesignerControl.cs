using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MechForge.Domain;

namespace MechForge.UserControls
{
    public class DesignerControl<T> : IDesignerControl
    {
        public T Data { get; set; }

        public UserControl ControlSet
        {
            get
            {
                return (UserControl)Activator.CreateInstance(controlSetLookup[typeof(T)]);
            }
        }

        private readonly Dictionary<Type, Type> controlSetLookup = new Dictionary<Type, Type>()
        {
            {typeof(Weapon), typeof(WeaponDesignerControlSet)},
            {typeof(Chassis), typeof(ChassisDesignerControlSet)}
        };


    }
}