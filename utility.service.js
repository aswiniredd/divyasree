//Utility service created for generic/common functionality services that can be used in multiple components of the application.(All server http calls will happen in 'tcoservice.service.js')
(function () {
    'use strict';
    utilityService.$inject = [];

    function utilityService() {
        var SignalPredictionImportObj = {};
        var signalPredictionDefaultMsg = "Signal prediction pending to be completed for this hole section";
        var signalPredictionReturnMsg = "";        
        var service = {
            dirtyLoadOuts : [],
            limitToFilter: limitToFilter,
            getSignalPredictionImport: getSignalPredictionImport,
            setSignalPredictionImport: setSignalPredictionImport,
            getSignalPredictionDefaultMsg: getSignalPredictionDefaultMsg,
            getSignalPredictionReturnMsg: getSignalPredictionReturnMsg,
            setSignalPredictionReturnMsg: setSignalPredictionReturnMsg,
            displayUnitConversion: displayUnitConversion,
            dbUnitConversion: dbUnitConversion,
            replaceSpecialChars: replaceSpecialChars
        };

        return service;

        function limitToFilter(data, limit) {
            return data.slice(0, limit);
        }

        //start - siva
        // for getting import objects from tcoConfiguration to confirmation component
        function getSignalPredictionImport()
        {
            return SignalPredictionImportObj;
        }

        function setSignalPredictionImport(data) {
            SignalPredictionImportObj = data;
        }

        function getSignalPredictionDefaultMsg()
        {
            return signalPredictionDefaultMsg;
        }

        function getSignalPredictionReturnMsg() {
            return signalPredictionReturnMsg;
        }

        function setSignalPredictionReturnMsg(data) {
            signalPredictionReturnMsg=data;
        }
        //end - siva

        //for Display/View
        function displayUnitConversion(units, val, UOM) {

            if (units == null) {
                return val;
            }
            if (val == null) {
                return "";
            }
            if (UOM == null || isNaN(val)) {
                return val;
            }

            var ConvertedValue = parseFloat(val);

            switch (UOM) {
                case 'DEN':
                    switch (units) {
                        case 'd/dd':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'g/cc':
                            ConvertedValue = ConvertedValue * 1;
                            break;
                        case 'kg/cc':
                            ConvertedValue = ConvertedValue * 0.001;
                            break;
                        case 'lb/gal':
                            ConvertedValue = (ConvertedValue) * 8.3454;
                            break;
                        case 'kg/m3':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;

                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'DEP':
                    switch (units) {
                        case 'm':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'ft':
                            ConvertedValue = (ConvertedValue) * 3.28084;
                            break;
                        case 'cm':
                            ConvertedValue = (ConvertedValue) * 100;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'DIA':
                    switch (units) {
                        case 'cm':
                            ConvertedValue = (ConvertedValue) / 10;
                            break;
                        case 'mm':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'in':
                            ConvertedValue = (ConvertedValue) / 25.400000000000002;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'FLO':
                    switch (units) {
                        case 'GPM':
                            ConvertedValue = (ConvertedValue) * 4.403;
                            break;
                        case 'LPM':
                            ConvertedValue = (ConvertedValue) * 16.67;
                            break;
                        case 'm3/hr': 
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'm3/min':
                            ConvertedValue = (ConvertedValue) * 0.01667;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;

                    }
                    break;
                case 'INC':
                    switch (units) {
                        case 'Deg':
                            ConvertedValue = ConvertedValue / 0.01745;
                            break;
                        case 'Rad':
                            ConvertedValue = (ConvertedValue) * 1; //0.01745329252;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;

                    }
                    break;
                case 'MAS':
                    switch (units) {
                        case 'kg':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'Klbs':
                            ConvertedValue = (ConvertedValue) / 453.60000000000002;
                            break;
                        case 'lbs':
                            ConvertedValue = (ConvertedValue) / 0.4536;
                            break;
                        case 'daN':
                            ConvertedValue = (ConvertedValue) / 2.2482000000000002;
                            break;
                        case 'g':
                            ConvertedValue = (ConvertedValue) / 0.001;
                            break;
                        case 'Tons':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;

                    }
                    break;
                case 'HMASS':
                    switch (units) {
                        case 'lbm':
                            ConvertedValue = (ConvertedValue) / 0.4536;
                            break;
                        case 'kg':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'klbm':
                            ConvertedValue = (ConvertedValue) / 453.6;
                            break;
                        case 'daN':
                            ConvertedValue = (ConvertedValue) / 2.2482;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;

                    }
                    break;
                case 'PRE':
                    switch (units) {
                        case 'Bar':
                            ConvertedValue = (ConvertedValue) * 1.01325;
                            break;
                        case 'Pa':
                            ConvertedValue = (ConvertedValue) * 101325;
                            break;
                        case 'atm':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'kPa':
                            ConvertedValue = (ConvertedValue) * 101.325;
                            break;
                        case 'PSI':
                            ConvertedValue = (ConvertedValue) * 14.6959;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'TEM':
                    switch (units) {
                        case 'degC':
                            ConvertedValue = ConvertedValue - 273.15;
                            break;
                        case 'degF':
                            ConvertedValue = Number((ConvertedValue - 273.15) * (9 / 5)) + 32;
                            break;
                        case 'degK':
                            ConvertedValue = Number(ConvertedValue) * 1;

                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                   //console.log(ConvertedValue);
                    break;

                case 'TOR':
                    switch (units) {
                        case 'ft-lbs':
                            ConvertedValue = (ConvertedValue) / 1.35582;
                            break;
                        case 'kN-m':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;
                        case 'N-m':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'in-lbs':
                            ConvertedValue = (ConvertedValue) / 0.1129848;
                            break;
                        case 'Kft-lbs':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'VOL':
                    switch (units) {
                        // Pump Stroke
                        case 'L/stroke':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;
                        case 'galUS/stroke':
                            ConvertedValue = (ConvertedValue) / 264.1721;
                            break;
                        case 'm3/stroke':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'JETSIZE':
                    switch (units) {
                        case 'mm':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case '/32 in':
                            ConvertedValue = (ConvertedValue) / 0.79375;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'DLS':
                    switch (units) {
                        case 'deg/100 ft':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'deg/30 m':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'LEN':
                    switch (units) {
                        case 'mm':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        case 'cm':
                            ConvertedValue = (ConvertedValue) / 10;
                            break;
                        case 'm':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;
                        case 'ft':
                            ConvertedValue = (ConvertedValue) / 304.8;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;

                default:
                    ConvertedValue = ConvertedValue / 1;
            }


            if (ConvertedValue == 0) {
                return 0;
            }
            else {
                return parseFloat(ConvertedValue).toFixed(2);
            }

        }
        //for Calc/DB
        function dbUnitConversion(units, val, UOM) {
            
            if (units == null) {
                return val;
            }
            if (val == null || val == "") {
                return "";
            }
            if (UOM == null || isNaN(val)) {
                return val;
            }
            var ConvertedValue = parseFloat(val);
            switch (UOM) {
                case 'DEN':
                    switch (units) {
                        case 'd/dd':
                            ConvertedValue = (ConvertedValue)/ 1;
                            break;
                        case 'g/cc':
                            ConvertedValue = ConvertedValue / 1;
                            break;
                        case 'kg/cc':
                            ConvertedValue = ConvertedValue / 0.001;
                            break;
                        case 'lb/gal':
                            ConvertedValue = (ConvertedValue) / 8.3454;
                            break;
                        case 'kg/m3':
                            ConvertedValue = (ConvertedValue) / 1000;
                            break;

                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                    // Depth Default SI unit as per TBLREFUOM is m
                case 'DEP':
                    switch (units) {

                        case 'm':
                            ConvertedValue = (ConvertedValue) / 1 ;
                            break;
                        case 'ft':
                            ConvertedValue = (ConvertedValue) * 0.3048;
                            break;
                        case 'cm':
                            ConvertedValue = (ConvertedValue) * 0.01;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;

                    }
                    break;

                case 'DIA':
                    switch (units) {
                        case 'cm':
                            ConvertedValue = (ConvertedValue) * 10;
                            break;
                        case 'mm':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'in':
                            ConvertedValue = (ConvertedValue) * 25.400000000000002;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
					//Default SI unit as per TBLREFUOM for flow is m3/hr
                case 'FLO':
                    switch (units) {
                        case 'GPM':
                            ConvertedValue = (ConvertedValue) / 4.403;
                            break;
                        case 'LPM':
                            ConvertedValue = (ConvertedValue) / 16.67;
                            break;
                        case 'm3/hr':
                            ConvertedValue = (ConvertedValue) * 1
                            break;
                        case 'm3/min':
                            ConvertedValue = (ConvertedValue) / 0.01667;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'INC':
                    switch (units) {
                        case 'Deg':
                            ConvertedValue = (ConvertedValue) * 0.01745;
                            break;
                        case 'Rad':
                            ConvertedValue = (ConvertedValue) / 1;
                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'MAS':
                    switch (units) {
                        case 'kg':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'Klbs':
                            ConvertedValue = (ConvertedValue) * 453.60000000000002;
                            break;
                        case 'lbs':
                            ConvertedValue = (ConvertedValue) * 0.4536;
                            break;
                        case 'daN':
                            ConvertedValue = (ConvertedValue) * 2.2482000000000002;
                            break;
                        case 'g':
                            ConvertedValue = (ConvertedValue) * 0.001;
                            break;
                        case 'Tons':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'HMASS':
                    switch (units) {
                        case 'lbm':
                            ConvertedValue = (ConvertedValue) * 0.4536;
                            break;
                        case 'kg':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'klbm':
                            ConvertedValue = (ConvertedValue) * 453.6;
                            break;
                        case 'daN':
                            ConvertedValue = (ConvertedValue) * 2.2482;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;

                    }
					break;
                    //Default SI unit as per TBLREFUOM for pressue is atm
                case 'PRE':
                    switch (units) {
                        case 'Bar':
                            ConvertedValue = (ConvertedValue) * 0.98692000000000002;
                            break;
                        case 'Pa':
                            ConvertedValue = (ConvertedValue) * 0.00000986923266716;
                            break;
                        case 'atm':
                            ConvertedValue = (ConvertedValue) * 1
                            break;
                        case 'kPa':
                            ConvertedValue = (ConvertedValue) * 0.00986923266716;
                            break;
                        case 'PSI':
                            ConvertedValue = (ConvertedValue) * 0.0680461897536047;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                    //Default SI unit as per TBLREFUOM for temperature is Kelvin
                case 'TEM':
                    switch (units) {
                        case 'degC':
                            ConvertedValue = ConvertedValue + 273.15;
                            break;
                        case 'degF':
                            ConvertedValue = 273.15 + ((Number(ConvertedValue) - 32) * 5 / 9); //(Number(ConvertedValue) - 32) * (5 / 9)
                            break;
                        case 'degK':
                            ConvertedValue = Number(ConvertedValue) * 1;

                            break;
                        default:
                            ConvertedValue = ConvertedValue / 1;
                    }
                    break;
                case 'TOR':
                    switch (units) {
                        case 'ft-lbs':
                            ConvertedValue = (ConvertedValue) * 1.35582;
                            break;
                        case 'kN-m':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;
                        case 'N-m':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'in-lbs':
                            ConvertedValue = (ConvertedValue) * 0.1129848;
                            break;
                        case 'Kft-lbs':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;

                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'VOL':
                    switch (units) {
                        case 'L/stroke':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;
                        case 'galUS/stroke':
                            ConvertedValue = (ConvertedValue) * 264.1721;
                            break;
                        case 'm3/stroke':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'JETSIZE':
                    switch (units) {
                        case 'mm':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case '/32 in':
                            ConvertedValue = (ConvertedValue) * 0.79375;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'DLS':
                    switch (units) {
                        case 'deg/100 ft':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'deg/30 m':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;
                    }
                    break;
                case 'LEN':
                    switch (units) {
                        case 'mm':
                            ConvertedValue = (ConvertedValue) * 1;
                            break;
                        case 'cm':
                            ConvertedValue = (ConvertedValue) * 10;
                            break;
                        case 'm':
                            ConvertedValue = (ConvertedValue) * 1000;
                            break;
                        case 'ft':
                            ConvertedValue = (ConvertedValue) * 304.8;
                            break;
                        default:
                            ConvertedValue = ConvertedValue * 1;

                    }
                    break;

                default:
                    ConvertedValue = ConvertedValue;
            }

            //if (ConvertedValue == 0) {
            //    return "";
            //}
            //else {
                return (ConvertedValue);
            //}
        }

        //Replace all special characters with "_"
        function replaceSpecialChars(value) {
            var strValue = value ? value.trim().replace(/[^\w\s]/gi, '') : "";  
            return strValue.replace(/[ ]/g, "_");
        }
    }

    angular
        .module('TCO.service')
        .service('utilityService', utilityService);
})();