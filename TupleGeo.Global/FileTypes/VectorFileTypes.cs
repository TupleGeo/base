﻿
#region Header
// Title Name       : VectorFileTypes
// Member of        : TupleGeo.General.dll
// Description      : Vector file types enumeration.
// Created by       : 07/02/2009, 06:01, Vasilis Vlastaras.
// Updated by       : 19/02/2009, 00:46, Vasilis Vlastaras.
//                    1.0.1 - Moved class from another assembly.
//                  : 26/03/2009, 19:40, Vasilis Vlastaras.
//                    1.0.2 - Added System.Xml.Serialization namespace / Cleaned up file.
//                  : 22/02/2011, 22:16, Vasilis Vlastaras.
//                    1.0.3 - Removed System.Linq to make the source file compatible with .NET Framework 2.0.
// Version          : 1.0.3
// Contact Details  : TupleGeo.
// License          : Apache License.
// Copyright        : TupleGeo, 2009 - 2015.
// Comments         : 
#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using TupleGeo.General.Attributes;

#endregion

namespace TupleGeo.General.FileTypes {

  /// <summary>
  /// Types of vector files.
  /// </summary>
  [SerializableAttribute()]
  [XmlTypeAttribute(AnonymousType=false)]
  public enum VectorFileTypes {

    /// <summary>
    /// Acorn Draw file format.
    /// </summary>
    [XmlEnumAttribute("acorn")]
    [DescriptionAttribute("Acorn Draw file format")]
    [DescriptionAttribute("Μορφότυπος αρχείου Acorn Draw", "el-GR")]
    Acorn,
    
    /// <summary>
    /// Adobe Illustrator graphics file format.
    /// </summary>
    [XmlEnumAttribute("ai")]
    [DescriptionAttribute("Adobe Illustrator graphics file format")]
    [DescriptionAttribute("Μορφότυπος αρχείου γραφικών Adobe Illustrator", "el-GR")]
    Ai,
    
    /// <summary>
    /// Adobe Illustrator template file format.
    /// </summary>
    [XmlEnumAttribute("ait")]
    [DescriptionAttribute("Adobe Illustrator template file format")]
    Ait,
    
    /// <summary>
    /// Adobe Illustrator graphics file format.
    /// </summary>
    [XmlEnumAttribute("art")]
    [DescriptionAttribute("Adobe Illustrator graphics file format")]
    Art,
    
    /// <summary>
    /// Ability Draw file format.
    /// </summary>
    [XmlEnumAttribute("awg")]
    [DescriptionAttribute("Ability Draw file format")]
    Awg,
    
    /// <summary>
    /// CorelDRAW vector image file format.
    /// </summary>
    [XmlEnumAttribute("cdr")]
    [DescriptionAttribute("CorelDRAW vector image file format")]
    Cdr,

    /// <summary>
    /// CorelDRAW 3 drawing file format.
    /// </summary>
    [XmlEnumAttribute("cdr3")]
    [DescriptionAttribute("CorelDRAW 3 drawing file format")]
    Cdr3,
    
    /// <summary>
    /// CorelDRAW 4 drawing file format.
    /// </summary>
    [XmlEnumAttribute("cdr4")]
    [DescriptionAttribute("CorelDRAW 4 drawing file format")]
    Cdr4,
    
    /// <summary>
    /// CorelDRAW 5 drawing file format.
    /// </summary>
    [XmlEnumAttribute("cdr5")]
    [DescriptionAttribute("CorelDRAW 5 drawing file format")]
    Cdr5,
    
    /// <summary>
    /// CorelDRAW 6 drawing file format.
    /// </summary>
    [XmlEnumAttribute("cdr6")]
    [DescriptionAttribute("CorelDRAW 6 drawing file format")]
    Cdr6,
    
    /// <summary>
    /// CorelDRAW file format.
    /// </summary>
    [XmlEnumAttribute("cdrw")]
    [DescriptionAttribute("CorelDRAW file format")]
    Cdrw,
    
    /// <summary>
    /// CorelDRAW Template file format.
    /// </summary>
    [XmlEnumAttribute("cdt")]
    [DescriptionAttribute("CorelDRAW Template file format")]
    Cdt,
    
    /// <summary>
    /// Computer graphics metafile file format.
    /// </summary>
    [XmlEnumAttribute("cgm")]
    [DescriptionAttribute("Computer graphics metafile file format")]
    Cgm,
    
    /// <summary>
    /// SeeYou vector maps file format.
    /// </summary>
    [XmlEnumAttribute("cit")]
    [DescriptionAttribute("SeeYou vector maps file format")]
    Cit,
    
    /// <summary>
    /// CorelDRAW vector image file format.
    /// </summary>
    [XmlEnumAttribute("cmx")]
    [DescriptionAttribute("CorelDRAW vector image file format")]
    Cmx,

    /// <summary>
    /// Adobe Photoshop shapes file format.
    /// </summary>
    [XmlEnumAttribute("csh")]
    [DescriptionAttribute("Adobe Photoshop shapes file format")]
    Csh,

    /// <summary>
    /// Corel symbol library file format.
    /// </summary>
    [XmlEnumAttribute("csl")]
    [DescriptionAttribute("Corel symbol library file format")]
    Csl,

    /// <summary>
    /// Cadterns Sloper File file format.
    /// </summary>
    [XmlEnumAttribute("ctn")]
    [DescriptionAttribute("Cadterns Sloper File file format")]
    Ctn,

    /// <summary>
    /// Intergraph design file file format.
    /// </summary>
    [XmlEnumAttribute("dgn")]
    [DescriptionAttribute("Intergraph design file file format")]
    Dgn,

    /// <summary>
    /// Digital Line Graph vector image file format.
    /// </summary>
    [XmlEnumAttribute("dlg")]
    [DescriptionAttribute("Digital Line Graph vector image file format")]
    Dlg,
    
    /// <summary>
    /// Digital Line Graph optional vector data file format.
    /// </summary>
    [XmlEnumAttribute("do")]
    [DescriptionAttribute("Digital Line Graph optional vector data file format")]
    Do,

    /// <summary>
    /// Vector file format.
    /// </summary>
    [XmlEnumAttribute("drw")]
    [DescriptionAttribute("Vector file format")]
    Drw,

    /// <summary>
    /// Autocad drawing file format.
    /// </summary>
    [XmlEnumAttribute("dwg")]
    [DescriptionAttribute("Autocad drawing file format")]
    Dwg,
    
    /// <summary>
    /// AutoCAD drawing exchange file format (Binary).
    /// </summary>
    [XmlEnumAttribute("dxb")]
    [DescriptionAttribute("AutoCAD drawing exchange file format (Binary)")]
    Dxb,
    
    /// <summary>
    /// AutoCAD drawing exchange file format (AScII).
    /// </summary>
    [XmlEnumAttribute("dxf")]
    [DescriptionAttribute("AutoCAD drawing exchange file format (AScII)")]
    Dxf,

    /// <summary>
    /// 2-dimensional vector graphics file format (Used by the editor which is included in JFire).
    /// </summary>
    [XmlEnumAttribute("e2d")]
    [DescriptionAttribute("2-dimensional vector graphics file format (Used by the editor which is included in JFire)")]
    E2d,
    
    /// <summary>
    /// EGT Universal Document file format, (EGT Vector Draw images are used to draw vector to a website).
    /// </summary>
    [XmlEnumAttribute("egt")]
    [DescriptionAttribute("EGT Universal Document file format, (EGT Vector Draw images are used to draw vector to a website)")]
    Egt,
    
    /// <summary>
    /// Orchida Embroidery System embroidery pattern file format.
    /// </summary>
    [XmlEnumAttribute("emb")]
    [DescriptionAttribute("Orchida Embroidery System embroidery pattern file format")]
    Emb,
    
    /// <summary>
    /// Enhanced Windows MetaFile format.
    /// </summary>
    [XmlEnumAttribute("emf")]
    [DescriptionAttribute("Enhanced Windows MetaFile format")]
    Emf,
    
    /// <summary>
    /// Encapsulated Postscript file format.
    /// </summary>
    [XmlEnumAttribute("eps")]
    [DescriptionAttribute("Encapsulated Postscript file format")]
    Eps,
    
    /// <summary>
    /// Image file format.
    /// </summary>
    [XmlEnumAttribute("fh")]
    [DescriptionAttribute("Image file format")]
    Fh,

    /// <summary>
    /// Adobe FreeHand 10 drawing file format.
    /// </summary>
    [XmlEnumAttribute("fh10")]
    [DescriptionAttribute("Adobe FreeHand 10 drawing file format")]
    Fh10,

    /// <summary>
    /// Adobe FreeHand 11 drawing file format.
    /// </summary>
    [XmlEnumAttribute("fh11")]
    [DescriptionAttribute("Adobe FreeHand 11 drawing file format")]
    Fh11,

    /// <summary>
    /// Adobe FreeHand 8 drawing file format.
    /// </summary>
    [XmlEnumAttribute("fh8")]
    [DescriptionAttribute("Adobe FreeHand 8 drawing file format")]
    Fh8,

    /// <summary>
    /// Adobe FreeHand 9 drawing file format.
    /// </summary>
    [XmlEnumAttribute("fh9")]
    [DescriptionAttribute("Adobe FreeHand 9 drawing file format")]
    Fh9,
    
    /// <summary>
    /// Adobe FreeHand 10 template file format.
    /// </summary>
    [XmlEnumAttribute("ft10")]
    [DescriptionAttribute("Adobe FreeHand 10 template file format")]
    Ft10,
    
    /// <summary>
    /// Adobe FreeHand 11 template file format.
    /// </summary>
    [XmlEnumAttribute("ft11")]
    [DescriptionAttribute("Adobe FreeHand 11 template file format")]
    Ft11,

    /// <summary>
    /// Adobe FreeHand 8 template file format.
    /// </summary>
    [XmlEnumAttribute("ft8")]
    [DescriptionAttribute("Adobe FreeHand 8 template file format")]
    Ft8,
    
    /// <summary>
    /// Adobe FreeHand 9 template file format.
    /// </summary>
    [XmlEnumAttribute("ft9")]
    [DescriptionAttribute("Adobe FreeHand 9 template file format")]
    Ft9,

    /// <summary>
    /// Generic CADD Drawing file format.
    /// </summary>
    [XmlEnumAttribute("gcd")]
    [DescriptionAttribute("Generic CADD Drawing file format")]
    Gcd,
    
    /// <summary>
    /// Ventura Publisher GEM vector picture file format.
    /// </summary>
    [XmlEnumAttribute("gem")]
    [DescriptionAttribute("Ventura Publisher GEM vector picture file format")]
    Gem,
    
    /// <summary>
    /// Hewlett Packard Graphics Language plotter file format.
    /// </summary>
    [XmlEnumAttribute("gl2")]
    [DescriptionAttribute("Hewlett Packard Graphics Language plotter file format")]
    Gl2,
    
    /// <summary>
    /// Hewlett Packard Graphics Language plotter file format.
    /// </summary>
    [XmlEnumAttribute("hpg")]
    [DescriptionAttribute("Hewlett Packard Graphics Language plotter file format")]
    Hpg,
    
    /// <summary>
    /// Hewlett Packard Graphics Language plotter file format.
    /// </summary>
    [XmlEnumAttribute("hpgl")]
    [DescriptionAttribute("Hewlett Packard Graphics Language plotter file format")]
    Hpgl,
    
    /// <summary>
    /// Hewlett Packard Graphics Language 2 plotter file format.
    /// </summary>
    [XmlEnumAttribute("hpgl2")]
    [DescriptionAttribute("Hewlett Packard Graphics Language 2 plotter file format")]
    Hpgl2,
    
    /// <summary>
    /// EGO - Chart - Autumn Mirage vector graphics file fomrat.
    /// </summary>
    [XmlEnumAttribute("ima")]
    [DescriptionAttribute("Mapinfo graphics file format")]
    Ima,

    /// <summary>
    /// Mapinfo graphics file format.
    /// </summary>
    [XmlEnumAttribute("mif")]
    [DescriptionAttribute("EGO - Chart - Autumn Mirage vector graphics file fomrat")]
    Mif,

    /// <summary>
    /// OpenOffice Draw graphic file format.
    /// </summary>
    [XmlEnumAttribute("odg")]
    [DescriptionAttribute("OpenOffice Draw graphic file format")]
    Odg,
    
    /// <summary>
    /// Corel vector pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_Corel")]
    [DescriptionAttribute("Corel vector pattern file format")]
    Pat_Corel,
    
    /// <summary>
    /// Pattern Maker Cross-Stitch Pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_PatternMaker")]
    [DescriptionAttribute("Pattern Maker Cross-Stitch Pattern file format")]
    Pat_PatternMaker,
    
    /// <summary>
    /// PatternSmith Cutting Pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_PatternSmith")]
    [DescriptionAttribute("PatternSmith Cutting Pattern file format")]
    Pat_PatternSmith,
    
    /// <summary>
    /// Polygon Attribute Table file format.
    /// </summary>
    [XmlEnumAttribute("pat_ArcInfo")]
    [DescriptionAttribute("Polygon Attribute Table file format")]
    Pat_ArcInfo,
    
    /// <summary>
    /// Vector Pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_VectorPattern")]
    [DescriptionAttribute("Vector Pattern file format")]
    Pat_VectorPattern,
    
    /// <summary>
    /// Corel Paint Shop Pro Pattern Image File.
    /// </summary>
    [XmlEnumAttribute("pat_PaintShop")]
    [DescriptionAttribute("Corel Paint Shop Pro Pattern Image File")]
    Pat_PaintShop,
    
    /// <summary>
    /// PCStitch Pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_PCStitch")]
    [DescriptionAttribute("PCStitch Pattern file format")]
    Pat_PCStitch,
    
    /// <summary>
    /// Smash Simulator Test Pattern file format.
    /// </summary>
    [XmlEnumAttribute("pat_SmashSimulator")]
    [DescriptionAttribute("Smash Simulator Test Pattern file format")]
    Pat_SmashSimulator,
    
    /// <summary>
    /// Cadterns Sloper file format.
    /// </summary>
    [XmlEnumAttribute("pat_Cadterns")]
    [DescriptionAttribute("Cadterns Sloper file format")]
    Pat_Cadterns,
    
    /// <summary>
    /// Orchida Embroidery System file format.
    /// </summary>
    [XmlEnumAttribute("pat_Orchida")]
    [DescriptionAttribute("Orchida Embroidery System file format")]
    Pat_Orchida,
    
    /// <summary>
    /// Apple Macintosh QuickDraw/PICT bitmap graphics file format.
    /// </summary>
    [XmlEnumAttribute("pct")]
    [DescriptionAttribute("Apple Macintosh QuickDraw/PICT bitmap graphics file format")]
    Pct,
    
    /// <summary>
    /// Vector image GDF file format.
    /// </summary>
    [XmlEnumAttribute("pif")]
    [DescriptionAttribute("Vector image GDF file format")]
    Pif,
    
    /// <summary>
    /// Image Systems vector file format.
    /// </summary>
    [XmlEnumAttribute("pix_ImageSystems")]
    [DescriptionAttribute("Image Systems vector file format")]
    Pix_ImageSystems,
    
    /// <summary>
    /// Inset Systems raster and vector file format.
    /// </summary>
    [XmlEnumAttribute("pix_InsetSystems")]
    [DescriptionAttribute("Inset Systems raster & vector file format")]
    Pix_InsetSystems,
    
    /// <summary>
    /// Hewlett Packard Graphics Language plotter file format.
    /// </summary>
    [XmlEnumAttribute("plo")]
    [DescriptionAttribute("Hewlett Packard Graphics Language plotter file format")]
    Plo,

    /// <summary>
    /// Vector graphics file format.
    /// </summary>
    [XmlEnumAttribute("plot")]
    [DescriptionAttribute("Vector graphics file format")]
    Plot,
    
    /// <summary>
    /// Autodesk AutoCAD HPGL vector graphic plotter file format.
    /// </summary>
    [XmlEnumAttribute("plt")]
    [DescriptionAttribute("Autodesk AutoCAD HPGL vector graphic plotter file format")]
    Plt,
    
    /// <summary>
    /// PostScript file format.
    /// </summary>
    [XmlEnumAttribute("ps")]
    [DescriptionAttribute("PostScript file format")]
    Ps,

    /// <summary>
    /// Amidraw vector image file format.
    /// </summary>
    [XmlEnumAttribute("sdw_Amidraw")]
    [DescriptionAttribute("Amidraw vector image file format")]
    Sdw_Amidraw,
    
    /// <summary>
    /// WordPro drawing file format.
    /// </summary>
    [XmlEnumAttribute("sdw_WordPro")]
    [DescriptionAttribute("WordPro drawing file format")]
    Sdw_WordPro,
    
    /// <summary>
    /// ESRI Shapefile format.
    /// </summary>
    [XmlEnumAttribute("shp")]
    [DescriptionAttribute("ESRI Shapefile format")]
    Shp,
    
    /// <summary>
    /// SolidWorks drawing 2D file format.
    /// </summary>
    [XmlEnumAttribute("slddwg")]
    [DescriptionAttribute("SolidWorks drawing 2D file format")]
    Slddwg,
    
    /// <summary>
    /// SignPlot output file format.
    /// </summary>
    [XmlEnumAttribute("sp")]
    [DescriptionAttribute("SignPlot output file format")]
    Sp,
    
    /// <summary>
    /// FutureSplash Movie file format.
    /// </summary>
    [XmlEnumAttribute("spa")]
    [DescriptionAttribute("FutureSplash Movie file format")]
    Spa,
    
    /// <summary>
    /// Stereo Lithographic data file format.
    /// </summary>
    [XmlEnumAttribute("stl")]
    [DescriptionAttribute("Stereo Lithographic data file format")]
    Stl,
    
    /// <summary>
    /// Simple Vector file format.
    /// </summary>
    [XmlEnumAttribute("svf")]
    [DescriptionAttribute("Simple Vector file format")]
    Svf,
    
    /// <summary>
    /// Scalable Vector Graphics file format.
    /// </summary>
    [XmlEnumAttribute("svg")]
    [DescriptionAttribute("Scalable Vector Graphics file format")]
    Svg,

    /// <summary>
    /// Vector file format.
    /// </summary>
    [XmlEnumAttribute("sxd")]
    [DescriptionAttribute("Vector file format")]
    Sxd,
    
    /// <summary>
    /// Top Draw vector graphic file format.
    /// </summary>
    [XmlEnumAttribute("tdr")]
    [DescriptionAttribute("Top Draw vector graphic file format")]
    Tdr,
    
    /// <summary>
    /// Voucher design file format (Used by the voucher management included in JFire).
    /// </summary>
    [XmlEnumAttribute("v2d")]
    [DescriptionAttribute("Voucher design file format (Used by the voucher management included in JFire)")]
    V2d,
    
    /// <summary>
    /// Virtual Reality Modeling Language file format.
    /// </summary>
    [XmlEnumAttribute("vrml")]
    [DescriptionAttribute("Virtual Reality Modeling Language file format")]
    Vrml,

    /// <summary>
    /// Windows metafile format.
    /// </summary>
    [XmlEnumAttribute("wmf")]
    [DescriptionAttribute("Windows metafile format")]
    Wmf,

    /// <summary>
    /// Virtual Reality Modeling Language file format (vrml).
    /// </summary>
    [XmlEnumAttribute("wrl")]
    [DescriptionAttribute("Virtual Reality Modeling Language file format (vrml)")]
    Wrl,

    /// <summary>
    /// Corel Xara drawing file format.
    /// </summary>
    [XmlEnumAttribute("xar")]
    [DescriptionAttribute("Corel Xara drawing file format")]
    Xar,

  }

}
