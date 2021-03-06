﻿/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

using Mochizuki.FileExtensions.Editor.Internal.Reflections.Expressions;

namespace Mochizuki.FileExtensions.Editor.Internal.Reflections
{
    public class ObjectListAreaState : ReflectionClass
    {
        public List<int> SelectedInstanceIds
        {
            get { return InvokeMember<List<int>>("m_SelectedInstanceIDs"); }
        }

        public List<int> ExpandedInstanceIds
        {
            get { return InvokeMember<List<int>>("m_ExpandedInstanceIDs"); }
        }

        public ObjectListAreaState(object instance) : base(instance, typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.ObjectListAreaState")) { }

        public bool IsRenaming(int instanceId)
        {
            var renameOverlay = new RenameOverlay(InvokeMember<object>("m_RenameOverlay"));
            return renameOverlay.IsRenaming() && renameOverlay.UserData == instanceId;
        }
    }
}