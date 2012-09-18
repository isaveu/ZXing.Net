﻿/*
* Copyright 2012 ZXing.Net authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;

using UnityEngine;

using ZXing;

namespace UnityDemo
{
   /// <summary>
   /// a barcode reader which uses the Color32LuminanceSource by default
   /// </summary>
   public class Color32BarcodeReader : BarcodeReaderGeneric<Color32[]>
   {
      public Color32BarcodeReader()
         : base(null, (rawColor32, width, height) => new Color32LuminanceSource(rawColor32, width, height), null)
      {
      }
      
      public Color32BarcodeReader(Reader reader,
         Func<Color32[], int, int, LuminanceSource> createLuminanceSource,
         Func<LuminanceSource, Binarizer> createBinarizer)
         : base(reader, createLuminanceSource ?? ((rawColor32, width, height) => new Color32LuminanceSource(rawColor32, width, height)), createBinarizer)
      {
      }
   }
}
