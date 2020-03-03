﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.net.Models
{
    public class Country
    {
        /// <summary>
        /// ISO 3166-1 alpha-3 (3 letter country code)
        /// </summary>
        public enum CountryCodes
        {
            AFG,
            ALA,
            ALB,
            DZA, 
            ASM, 
            AND,
            AGO,
            AIA, 
            ATA,
            ATG, 
            ARG,
            ARM,
            ABW,
            AUS, 
            AUT, 
            AZE, 
            BHS,
            BHR, 
            BGD,
            BRB,
            BLR, 
            BEL,
            BLZ,
            BEN,
            BMU,
            BTN,
            BOL,
            BES,
            BIH,
            BWA,
            BVT, 
            BRA,
            IOT,
            BRN, 
            BGR, 
            BFA,
            BDI,
            KHM, 
            CMR,
            CAN,
            CPV, CYM,
            CAF,
            TCD,
            CHL,  
            CHN, 
            CXR, 
            CCK,
            COL,
            COM,
            COG, 
            COD,
            COK, 
            CRI,
            CIV, 
            HRV,
            CUB,
            CUW, 
            CYP, 
            CZE, 
            DNK,
            DJI,
            DMA,
            DOM, 
            ECU, 
            EGY, 
            SLV, 
            GNQ, 
            ERI,
            EST, 
            ETH,
            FLK,
            FRO, 
            FJI, 
            FIN,
            FRA,
            GUF,
            PYF, 
            ATF,
            GAB, 
            GMB,
            GEO,
            DEU,
            GHA,
            GIB, 
            GRC,
            GRL, 
            GRD,
            GLP, 
            GUM,  
            GTM,
            GGY,
            GIN, 
            GNB,
            GUY, 
            HTI,
            HMD, 
            VAT,
            HND, 
            HKG, 
            HUN, 
            ISL, 
            IND, 
            IDN, 
            IRN, 
            IRQ,
            IRL,
            IMN,
            ISR,
            ITA,
            JAM,
            JPN,
            JEY, 
            JOR,
            KAZ, 
            KEN,
            KIR,
            PRK,
            KOR,
            KWT, 
            KGZ, 
            LAO,
            LVA,
            LBN,
            LSO,
            LBR,
            LBY,
            LIE, 
            LTU,
            LUX,
            MAC,
            MKD,
            MDG, 
            MWI,
            MYS,
            MDV,
            MLI,
            MLT,
            MHL,
            MTQ,
            MRT,
            MUS,
            MYT, 
            MEX, 
            FSM,
            MDA,
            MCO, 
            MNG,
            MNE, 
            MSR,
            MAR,
            MOZ,
            MMR,
            NAM,
            NRU, 
            NPL,
            NLD,
            NCL, 
            NZL,
            NIC, 
            NER,
            NGA,
            NIU, 
            NFK, 
            MNP, 
            NOR,
            OMN, 
            PAK,
            PLW, 
            PSE,
            PAN,
            PNG,
            PRY,
            PER, 
            PHL, 
            PCN, 
            POL,
            PRT, 
            PRI, 
            QAT, 
            REU,
            RKS,
            ROU,
            RUS,
            RWA, 
            BLM, 
            SHN, 
            KNA,
            LCA,
            MAF,
            SPM,
            VCT,
            WSM,
            SMR, 
            STP,
            SAU,
            SEN,
            SRB, 
            SYC, 
            SLE,
            SGP,
            SXM,
            SVK,
            SVN, 
            SLB,
            SOM,
            ZAF,
            SGS, 
            ESP,
            LKA, 
            SDN, 
            SUR,
            SSD,
            SJM, 
            SWZ,
            SWE,
            CHE,
            SYR, 
            TWN, 
            TJK,
            TZA,
            THA,
            TLS,
            TGO,
            TKL, 
            TON,
            TTO, 
            TUN, 
            TUR,
            TKM, 
            TCA, 
            TUV, 
            UGA,
            UKR,
            ARE,
            GBR, 
            USA,
            UMI,
            URY,
            UZB, 
            VUT,
            VEN,
            VNM,
            VGB,
            VIR, 
            WLF,
            ESH, 
            YEM, 
            ZMB, 
            ZWE
        }
    }
}
