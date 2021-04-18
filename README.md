# RevitLookup

[![Revit API](https://img.shields.io/badge/Revit%20API-2017%20to%202022-blue.svg)]()
[![Platform](https://img.shields.io/badge/platform-Windows-lightgray.svg)]()
[![.NET](https://img.shields.io/badge/.NET-4.5.2%20to%204.8-blue.svg)]()

Interactive Revit BIM database exploration tool to view and navigate element properties and relationships.


## <a name="versions"></a> Versions

The most up-to-date version provided here is for Revit Revit2017-2021.

## Installation

You install RevitLookup just like any other Revit add-in,
by [copying the add-in manifest and the assembly DLL to the Revit Add-Ins folder](http://help.autodesk.com/view/RVT/2019/ENU/?guid=Revit_API_Revit_API_Developers_Guide_Introduction_Add_In_Integration_Add_in_Registration_html).

<!----
by [copying the add-in manifest and the assembly DLL to the Revit Add-Ins folder](http://help.autodesk.com/view/RVT/2018/ENU/?guid=GUID-4FFDB03E-6936-417C-9772-8FC258A261F7).
---->


If you specify the full DLL pathname in the add-in manifest, it can also be located elsewhere.

## Caveat &ndash; RevitLookup Cannot Snoop Everything

This clarification was prompted by
the [issue #35 &ndash; RevitLookup doesn't snoop all members](https://github.com/jeremytammik/RevitLookup/issues/35):

**Question:** I tried snooping a selected Structural Rebar element in the active view and found not all of the Rebar class members showed up in the Snoop Objects window. One of many members that weren't there: `Rebar.GetFullGeometryForView` method.

Is this the expected behaviour? I was thinking I could get all object members just with  RevitLookup and without the Revit API help file `RevitAPI.chm`.

**Answer:** RevitLookup cannot report **all** properties and methods on **all** elements.

For instance, in the case of GetFullGeometryForView, a view input argument is required. How is RevitLookup supposed to be able to guess what view you are interested in?

For methods requiring dynamic input that cannot be automatically determined, you will have to [make use of more intimate interactive database exploration tools, e.g. RevitPythonShell](http://thebuildingcoder.typepad.com/blog/2013/11/intimate-revit-database-exploration-with-the-python-shell.html).


## Author

Maintained by Gopinath Rajendran,

