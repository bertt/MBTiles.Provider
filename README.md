MBTiles.Provider
================
[![Stories in Ready](https://badge.waffle.io/bertt/MBTiles.Provider.png?label=ready&title=Ready)](https://waffle.io/bertt/MBTiles.Provider)
[![NuGet Status](http://img.shields.io/nuget/v/MBTiles.Provider.svg?style=flat)](https://www.nuget.org/packages/MBTiles.Provider/)

Gets MBTiles as System.Drawing.Image

Usage:
```
var connectionString = string.Format("Data Source={0}", mbtilefile);
var mbTileProvider = new MBTileProvider(connectionString);
var image = mbTileProvider.GetTile(level, col, row);
```




