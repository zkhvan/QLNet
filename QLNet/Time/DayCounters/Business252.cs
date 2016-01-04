/*
 Copyright (C) 2008 Siarhei Novik (snovik@gmail.com)
  
 This file is part of QLNet Project https://github.com/amaggiulli/qlnet

 QLNet is free software: you can redistribute it and/or modify it
 under the terms of the QLNet license.  You should have received a
 copy of the license along with this program; if not, license is  
 available online at <http://qlnet.sourceforge.net/License.html>.
  
 QLNet is a based on QuantLib, a free-software/open-source library
 for financial quantitative analysts and developers - http://quantlib.org/
 The QuantLib license is available online at http://quantlib.org/license.shtml.
 
 This program is distributed in the hope that it will be useful, but WITHOUT
 ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 FOR A PARTICULAR PURPOSE.  See the license for more details.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNet
{
    //! Business/252 day count convention
    public class Business252 : DayCounter
    {
        private Calendar calendar_;

        // public Business252(Calendar c = Brazil())
        public Business252(Calendar c)
        {
            calendar_ = c;
            dayCounter_ = this;
        }

        public override string name() { return "Business/252(" + calendar_.name() + ")"; }
        public override int dayCount(Date d1, Date d2) { return calendar_.businessDaysBetween(d1, d2); }
        public override double yearFraction(Date d1, Date d2, Date d3, Date d4) { return dayCount(d1, d2) / 252.0; }
    }
}
