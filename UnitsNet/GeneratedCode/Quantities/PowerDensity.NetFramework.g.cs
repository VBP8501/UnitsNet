﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The amount of power in a volume.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct PowerDensity : IComparable, IComparable<PowerDensity>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable PowerDensity from nullable DecawattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromDecawattsPerCubicFoot(QuantityValue? decawattspercubicfoot)
        {
            return decawattspercubicfoot.HasValue ? FromDecawattsPerCubicFoot(decawattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DecawattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromDecawattsPerCubicInch(QuantityValue? decawattspercubicinch)
        {
            return decawattspercubicinch.HasValue ? FromDecawattsPerCubicInch(decawattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DecawattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromDecawattsPerCubicMeter(QuantityValue? decawattspercubicmeter)
        {
            return decawattspercubicmeter.HasValue ? FromDecawattsPerCubicMeter(decawattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DecawattsPerLiter.
        /// </summary>
        public static PowerDensity? FromDecawattsPerLiter(QuantityValue? decawattsperliter)
        {
            return decawattsperliter.HasValue ? FromDecawattsPerLiter(decawattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DeciwattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromDeciwattsPerCubicFoot(QuantityValue? deciwattspercubicfoot)
        {
            return deciwattspercubicfoot.HasValue ? FromDeciwattsPerCubicFoot(deciwattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DeciwattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromDeciwattsPerCubicInch(QuantityValue? deciwattspercubicinch)
        {
            return deciwattspercubicinch.HasValue ? FromDeciwattsPerCubicInch(deciwattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DeciwattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromDeciwattsPerCubicMeter(QuantityValue? deciwattspercubicmeter)
        {
            return deciwattspercubicmeter.HasValue ? FromDeciwattsPerCubicMeter(deciwattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable DeciwattsPerLiter.
        /// </summary>
        public static PowerDensity? FromDeciwattsPerLiter(QuantityValue? deciwattsperliter)
        {
            return deciwattsperliter.HasValue ? FromDeciwattsPerLiter(deciwattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable GigawattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromGigawattsPerCubicFoot(QuantityValue? gigawattspercubicfoot)
        {
            return gigawattspercubicfoot.HasValue ? FromGigawattsPerCubicFoot(gigawattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable GigawattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromGigawattsPerCubicInch(QuantityValue? gigawattspercubicinch)
        {
            return gigawattspercubicinch.HasValue ? FromGigawattsPerCubicInch(gigawattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable GigawattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromGigawattsPerCubicMeter(QuantityValue? gigawattspercubicmeter)
        {
            return gigawattspercubicmeter.HasValue ? FromGigawattsPerCubicMeter(gigawattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable GigawattsPerLiter.
        /// </summary>
        public static PowerDensity? FromGigawattsPerLiter(QuantityValue? gigawattsperliter)
        {
            return gigawattsperliter.HasValue ? FromGigawattsPerLiter(gigawattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable KilowattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromKilowattsPerCubicFoot(QuantityValue? kilowattspercubicfoot)
        {
            return kilowattspercubicfoot.HasValue ? FromKilowattsPerCubicFoot(kilowattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable KilowattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromKilowattsPerCubicInch(QuantityValue? kilowattspercubicinch)
        {
            return kilowattspercubicinch.HasValue ? FromKilowattsPerCubicInch(kilowattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable KilowattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromKilowattsPerCubicMeter(QuantityValue? kilowattspercubicmeter)
        {
            return kilowattspercubicmeter.HasValue ? FromKilowattsPerCubicMeter(kilowattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable KilowattsPerLiter.
        /// </summary>
        public static PowerDensity? FromKilowattsPerLiter(QuantityValue? kilowattsperliter)
        {
            return kilowattsperliter.HasValue ? FromKilowattsPerLiter(kilowattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MegawattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromMegawattsPerCubicFoot(QuantityValue? megawattspercubicfoot)
        {
            return megawattspercubicfoot.HasValue ? FromMegawattsPerCubicFoot(megawattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MegawattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromMegawattsPerCubicInch(QuantityValue? megawattspercubicinch)
        {
            return megawattspercubicinch.HasValue ? FromMegawattsPerCubicInch(megawattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MegawattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromMegawattsPerCubicMeter(QuantityValue? megawattspercubicmeter)
        {
            return megawattspercubicmeter.HasValue ? FromMegawattsPerCubicMeter(megawattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MegawattsPerLiter.
        /// </summary>
        public static PowerDensity? FromMegawattsPerLiter(QuantityValue? megawattsperliter)
        {
            return megawattsperliter.HasValue ? FromMegawattsPerLiter(megawattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MicrowattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromMicrowattsPerCubicFoot(QuantityValue? microwattspercubicfoot)
        {
            return microwattspercubicfoot.HasValue ? FromMicrowattsPerCubicFoot(microwattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MicrowattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromMicrowattsPerCubicInch(QuantityValue? microwattspercubicinch)
        {
            return microwattspercubicinch.HasValue ? FromMicrowattsPerCubicInch(microwattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MicrowattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromMicrowattsPerCubicMeter(QuantityValue? microwattspercubicmeter)
        {
            return microwattspercubicmeter.HasValue ? FromMicrowattsPerCubicMeter(microwattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MicrowattsPerLiter.
        /// </summary>
        public static PowerDensity? FromMicrowattsPerLiter(QuantityValue? microwattsperliter)
        {
            return microwattsperliter.HasValue ? FromMicrowattsPerLiter(microwattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MilliwattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromMilliwattsPerCubicFoot(QuantityValue? milliwattspercubicfoot)
        {
            return milliwattspercubicfoot.HasValue ? FromMilliwattsPerCubicFoot(milliwattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MilliwattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromMilliwattsPerCubicInch(QuantityValue? milliwattspercubicinch)
        {
            return milliwattspercubicinch.HasValue ? FromMilliwattsPerCubicInch(milliwattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MilliwattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromMilliwattsPerCubicMeter(QuantityValue? milliwattspercubicmeter)
        {
            return milliwattspercubicmeter.HasValue ? FromMilliwattsPerCubicMeter(milliwattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable MilliwattsPerLiter.
        /// </summary>
        public static PowerDensity? FromMilliwattsPerLiter(QuantityValue? milliwattsperliter)
        {
            return milliwattsperliter.HasValue ? FromMilliwattsPerLiter(milliwattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable NanowattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromNanowattsPerCubicFoot(QuantityValue? nanowattspercubicfoot)
        {
            return nanowattspercubicfoot.HasValue ? FromNanowattsPerCubicFoot(nanowattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable NanowattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromNanowattsPerCubicInch(QuantityValue? nanowattspercubicinch)
        {
            return nanowattspercubicinch.HasValue ? FromNanowattsPerCubicInch(nanowattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable NanowattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromNanowattsPerCubicMeter(QuantityValue? nanowattspercubicmeter)
        {
            return nanowattspercubicmeter.HasValue ? FromNanowattsPerCubicMeter(nanowattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable NanowattsPerLiter.
        /// </summary>
        public static PowerDensity? FromNanowattsPerLiter(QuantityValue? nanowattsperliter)
        {
            return nanowattsperliter.HasValue ? FromNanowattsPerLiter(nanowattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable PicowattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromPicowattsPerCubicFoot(QuantityValue? picowattspercubicfoot)
        {
            return picowattspercubicfoot.HasValue ? FromPicowattsPerCubicFoot(picowattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable PicowattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromPicowattsPerCubicInch(QuantityValue? picowattspercubicinch)
        {
            return picowattspercubicinch.HasValue ? FromPicowattsPerCubicInch(picowattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable PicowattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromPicowattsPerCubicMeter(QuantityValue? picowattspercubicmeter)
        {
            return picowattspercubicmeter.HasValue ? FromPicowattsPerCubicMeter(picowattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable PicowattsPerLiter.
        /// </summary>
        public static PowerDensity? FromPicowattsPerLiter(QuantityValue? picowattsperliter)
        {
            return picowattsperliter.HasValue ? FromPicowattsPerLiter(picowattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable TerawattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromTerawattsPerCubicFoot(QuantityValue? terawattspercubicfoot)
        {
            return terawattspercubicfoot.HasValue ? FromTerawattsPerCubicFoot(terawattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable TerawattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromTerawattsPerCubicInch(QuantityValue? terawattspercubicinch)
        {
            return terawattspercubicinch.HasValue ? FromTerawattsPerCubicInch(terawattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable TerawattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromTerawattsPerCubicMeter(QuantityValue? terawattspercubicmeter)
        {
            return terawattspercubicmeter.HasValue ? FromTerawattsPerCubicMeter(terawattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable TerawattsPerLiter.
        /// </summary>
        public static PowerDensity? FromTerawattsPerLiter(QuantityValue? terawattsperliter)
        {
            return terawattsperliter.HasValue ? FromTerawattsPerLiter(terawattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable WattsPerCubicFoot.
        /// </summary>
        public static PowerDensity? FromWattsPerCubicFoot(QuantityValue? wattspercubicfoot)
        {
            return wattspercubicfoot.HasValue ? FromWattsPerCubicFoot(wattspercubicfoot.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable WattsPerCubicInch.
        /// </summary>
        public static PowerDensity? FromWattsPerCubicInch(QuantityValue? wattspercubicinch)
        {
            return wattspercubicinch.HasValue ? FromWattsPerCubicInch(wattspercubicinch.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable WattsPerCubicMeter.
        /// </summary>
        public static PowerDensity? FromWattsPerCubicMeter(QuantityValue? wattspercubicmeter)
        {
            return wattspercubicmeter.HasValue ? FromWattsPerCubicMeter(wattspercubicmeter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Get nullable PowerDensity from nullable WattsPerLiter.
        /// </summary>
        public static PowerDensity? FromWattsPerLiter(QuantityValue? wattsperliter)
        {
            return wattsperliter.HasValue ? FromWattsPerLiter(wattsperliter.Value) : default(PowerDensity?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerDensityUnit" /> to <see cref="PowerDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PowerDensity unit value.</returns>
        public static PowerDensity? From(QuantityValue? value, PowerDensityUnit fromUnit)
        {
            return value.HasValue ? new PowerDensity((double)value.Value, fromUnit) : default(PowerDensity?);
        }

        #endregion

        #region Arithmetic Operators

        public static PowerDensity operator -(PowerDensity right)
        {
            return new PowerDensity(-right.Value, right.Unit);
        }

        public static PowerDensity operator +(PowerDensity left, PowerDensity right)
        {
            return new PowerDensity(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PowerDensity operator -(PowerDensity left, PowerDensity right)
        {
            return new PowerDensity(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PowerDensity operator *(double left, PowerDensity right)
        {
            return new PowerDensity(left * right.Value, right.Unit);
        }

        public static PowerDensity operator *(PowerDensity left, double right)
        {
            return new PowerDensity(left.Value * right, left.Unit);
        }

        public static PowerDensity operator /(PowerDensity left, double right)
        {
            return new PowerDensity(left.Value / right, left.Unit);
        }

        public static double operator /(PowerDensity left, PowerDensity right)
        {
            return left.WattsPerCubicMeter / right.WattsPerCubicMeter;
        }

        #endregion

        public static bool operator <=(PowerDensity left, PowerDensity right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(PowerDensity left, PowerDensity right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(PowerDensity left, PowerDensity right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(PowerDensity left, PowerDensity right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(PowerDensity left, PowerDensity right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(PowerDensity left, PowerDensity right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}