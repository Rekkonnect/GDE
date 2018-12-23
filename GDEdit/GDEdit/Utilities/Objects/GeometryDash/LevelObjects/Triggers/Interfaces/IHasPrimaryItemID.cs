﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDEdit.Utilities.Attributes;
using GDEdit.Utilities.Enumerations.GeometryDash.GamesaveValues;

namespace GDEdit.Utilities.Objects.GeometryDash.LevelObjects.Triggers.Interfaces
{
    /// <summary>Represents a trigger which contains a definition for a primary Item ID.</summary>
    public interface IHasPrimaryItemID
    {
        [ObjectStringMappable(ObjectParameter.ItemID)]
        int PrimaryItemID { get; set; }
    }
}