﻿using System;
using System.Collections.Generic;
using Pickup.Configs.Buildable.Structure;
using Pickup.World;
using Unity.Collections;
using UnityEngine;

namespace Pickup.Scenes.FieldScene
{
    public partial class StructureM : MonoBehaviour
    {
        private StructureC _type;

        public StructureC type
        {
            get => _type;
            set
            {
                value.Check(this);
                _type = value;
            }
        }

        public readonly Dictionary<string, dynamic> statCollection = new ()
        {
            ["health"] = 100
        };

        private void Update()
        {
            if (type.update) type.UpdateO(this);
        }
    }
}