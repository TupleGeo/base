﻿
#region Header
// Title Name       : IValidation
// Member of        : EraNet.GIS.ArcGIS.dll
// Description      : A generic interface used by any class that needs to provide validation logic.
// Created by       : 18/02/2010, 20:01, Vasilis Vlastaras.
// Updated by       : 22/02/2011, 21:42, Vasilis Vlastaras.
//                    1.0.1 - Removed System.Linq to make the source file compatible with .NET Framework 2.0.
// Version          : 1.0.1
// Contact Details  : TupleGeo.
// License          : Apache License.
// Copyright        : TupleGeo, 2010 - 2015.
// Comments         : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace TupleGeo.Global {

  /// <summary>
  /// A generic interface used by any class that needs to provide validation logic.
  /// </summary>
  public interface IValidation {

    /// <summary>
    /// <para>
    /// Call to perform a custom validation.
    /// </para>
    /// <para>
    /// In case problems found during the validation the method
    /// must fail returning a relevant exception to the caller.
    /// </para>
    /// </summary>
    void Validate();

  }

}
