namespace Slb.QTrac.Shared
{
    /// <summary>
    ///  Constant class to hold all the constant element for single point of reference
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Gets the tool hierarchy level1 name
        /// </summary>
        public static string TOOLHIERARCHYLEVEL1_NAME { get; } = "Oilfield Services";
        /// <summary>
        /// Gets the tool hierarchy level1 ID
        /// </summary>
        public static int TOOLHIERARCHYLEVEL1_ID { get; } = 1;
        /// <summary>
        /// Gets the tool hierarchy level1 parent id
        /// </summary>
        public static int? TOOLHIERARCHYLEVEL1_PARENTID { get; } = null;
        /// <summary>
        /// Gets the tool hierarchy level1 display order
        /// </summary>
        public static int TOOLHIERARCHYLEVEL1_DISPLAY_ORDER { get; } = 1;
        /// <summary>
        /// Gets the tool hierarchy level2 name
        /// </summary>
        public static string TOOLHIERARCHYLEVEL2_NAME { get; } = "Drilling Group";
        /// <summary>
        /// Gets the tool hierarchy level2 ID
        /// </summary>
        public static int TOOLHIERARCHYLEVEL2_ID { get; } = 2;
        /// <summary>
        /// Gets the tool hierarchy level2 parent id
        /// </summary>
        public static int? TOOLHIERARCHYLEVEL2_PARENTID { get; } = 1;
        /// <summary>
        /// Gets the tool hierarchy level2 display order
        /// </summary>
        public static int TOOLHIERARCHYLEVEL2_DISPLAY_ORDER { get; } = 1;
        /// <summary>
        /// Gets the tool hierarchy level3 parent id
        /// </summary>
        public static int? TOOLHIERARCHYLEVEL3_PARENTID { get; } = 2;
        /// <summary>
        /// Gets the table name of "R_TOOL_OPTIONS" table
        /// </summary>
        public static string INSPECTIONLEVEL { get; } = "INSPECTION LEVEL";
        public static string INSPECTIONCOMPANY { get; } = "INSPECTION COMPANY";
        public static string INSPECTIONPAPERWORK { get; } = "INSPECTION PAPERWORK";
        public static string MONITORINGCOMPANY { get; } = "MONITORING COMPANY";
        public static string BITYPE { get; } = "BIT TYPE";
        public static string LOADOUTSTATUS { get; } = "TCO Priority";
        //public static string MAXWELL { get; } = "MAXWELL";
        //public static string HSPM { get; } = "HSPM";
        public static string RX5RX6 { get; } = "RX 5/6";
        public static string MUDTYPE { get; } = "MUD_TYPE";
        public static string TCOPriority { get; } = "TCO Priority";
        public static string R_DIMENSION { get; } = "R_Dimension";
        public static string R_UOM { get; } = "R_UOM";
        public static string Density { get; } = "Density";
        public static string Depth { get; } = "Depth";
        public static string Diameter { get; } = "Diameter";
        public static string FlowRate { get; } = "Flow Rate";
        //public static string Inclination { get; } = "Inclination";
        public static string Mass { get; } = "Mass";
        public static string Pressure { get; } = "Pressure";
        public static string Temperature { get; } = "Temperature";
        public static string Torque { get; } = "Torque";
        public static string PumpStroke { get; } = "Pump Stroke";
        public static string HeavyMass { get; } = "Heavy Mass";
        public static string JetSize { get; } = "Jet Size";
        public static string DLS { get; } = "DLS";
        public static string Length { get; } = "Length";
        public static string DEN { get; } = "DEN";
        public static string DEP { get; } = "DEP";
        public static string DIA { get; } = "DIA";
        public static string FLO { get; } = "FLO";
        public static string INC { get; } = "INC";
        public static string MAS { get; } = "MAS";
        public static string PRE { get; } = "PRE";
        public static string TEM { get; } = "TEM";
        public static string TOR { get; } = "TOR";
        public static string VOL { get; } = "VOL";
        public static string HMASS { get; } = "HMASS";
        public static string JETSIZE { get; } = "JETSIZE";
        //public static string DLS { get; } = "DLS"; //Already defined in constants
        public static string LEN { get; } = "LEN";
        public static int Master_Site_ID { get; } = 1;
        public static string ReportCommand { get; } = "&rs:Command=Render";
        public static string ReportFormat { get; } = "&rs:Format=HTML4.0";
        public static string ReportStyleSheet { get; } = "&rc:Stylesheet=HtmlViewer_QTrac";
        public static string ParamJobNumber { get; } = "&JobNumber=";
        public static string ParamLdap { get; } = "&LDAP=";
        public static string DoubleSpace { get; } = "  ";
        public static string ParamFilter { get; } = "Filter : ";
        public static string BHStaticTemp { get; } = "BH Static Temperature";
        public static string BHP { get; } = "BHP";
        //public static string BHT { get; } = "BHT";
        //public static string DOGLEG { get; } = "DOGLEG";
        public static string ENDDEPTHMD { get; } = "END DEPTH MD";//En DEPTH MD need to update this if the name changes
        public static string ENDDEPTHTVD { get; } = "END DEPTH TVD";
        public static string HIGHCORROSIVE { get; } = "HIGH_CORROSIVE";
        public static string HIGHPRESSURE { get; } = "HIGH PRESSURE";
        public static string HIGHSHOCK { get; } = "HIGH_SHOCK";
        public static string HIGHTEMP { get; } = "HIGH TEMPERATURE";
        public static string ControlType { get; } = "R_CONTROL_TYPE";
        public static string MasterAttributeType { get; } = "R_MASTER_ATTRIBUTE_TYPE";

        //public static string INCLINATION { get; } = "INCLINATION";
        public static string MagSpacing { get; } = "Mag Spacing";
        public static string MaxDLS { get; } = "Max_DLS";
        public static string MUDDENSITY { get; } = "MUD DENSITY";
        public static string MUDPVTEMP { get; } = "MUD PV TEMP";
        public static string MUDVISCOSITY { get; } = "MUD VISCOSITY";
        public static string PLANNEDFLOWRATE { get; } = "PLANNED FLOW RATE";
        public static string PLANNEDFLOWRATEMIN { get; } = "PLANNED FLOW RATE MIN";
        public static string SEADEP { get; } = "SEA DEP";
        public static string STARTDEPTHMD { get; } = "START DEPTH MD"; // need to update this if the name changes
        public static string SURFTEMP { get; } = "SURF TEMP";
        public static string TRUCKINGCOMPANY { get; } = "TRUCKING COMPANY";
        public static string LOADOUT_MODIFICATION_LOG { get; } = "LOADOUT_MODIFICATION_LOG";
        public static string TCO_TEMPLATE { get; } = "TCO_TEMPLATE";
        public static string QTRAC { get; } = "QTRAC";
        public static string IDISTRICT { get; } = "IDISTRICT";
        public static string OPSPORTAL { get; } = "OPSPORTAL";
        public static string Public { get; } = "Public";
        public static string Private { get; } = "Private";
        public static string RequestToPublish { get; } = "Request To Publish";
        public static string ACTIVE { get; } = "ACTIVE";
        public static string ErrorSiteDoesNotExist { get; } = "The siteid does not exist";
        public static string ErrorLocationDoesNotExist { get; } = "The location code does not exist";
        public static string ErrorUserDoesNotExist { get; } = "The user does not exist";
        public static string COMMADelimitor { get; } = ",";
        public static string PublishReject { get; } = "publish/reject";
        public static string TCOTemplate { get; } = "TCOTemplate";
        public static string tblRefMapAreas { get; } = "tblRefMapAreas";
        public static string tblEquipment { get; } = "tblequipment";
        public static string TBLREFSEGMENTTableName { get; } = "tblRefSegment";
        public static string TBLUSERROLES { get; } = "tblUserRoles";
        /// <summary>
        /// Returns Cancelled
        /// </summary>
        public static string CancelledLowerCase { get; } = "Cancelled";
        public static string TOOL_ORDER { get; } = "TOOL_ORDER";
        public static string ErrorCancelEntireTco { get; } = "There are Tools in Released/Shipped status.TCO cannot be cancelled";
        public static string ErrorLoadoutModificationLog { get; } = "Insertion Falied for Loadout Modification Log.";
        public static string LogType { get; } = "Parameter";
        public static string StatusLabel { get; } = "Status";
        public static string ActionChanged { get; } = "Changed";
        public static string StatusCancelled { get; } = "Cancelled";
        public static string StatusRestored { get; } = "Restored";
        public static string StatusCreated { get; } = "Created";
        public static string StatusSubmitted { get; } = "Submitted";
        public static string StatusRedirected { get; } = "Redirected";
        public static string StatusPartiallyRedirected { get; } = "Partially  Redirected";
        public static string StatusReleased { get; } = "Released";
        public static string StatusRejected { get; } = "Rejected";
        public static string StatusShipped { get; } = "Shipped";
        public static string StatusAccepted { get; } = "Accepted";
        public static string StatusModified { get; } = "Modified";
        public static string StatusVoided { get; } = "VOIDED";
        //Constants for status
        public static int CreatedId { get; set; } = 1;
        public static int SubmittedId { get; set; } = 2;
        public static int ModifiedId { get; set; } = 3;
        public static int RejectedId { get; set; } = 5;
        public static int AcceptedId { get; set; } = 6;
        public static int ReleasedId { get; set; } = 7;
        public static int CancelledId { get; set; } = 15;
        public static int RedirectedId { get; set; } = 16;
        public static int ShippedId { get; set; } = 17;
        //Constants for redirection type
        public static int ShipToBaseID { get; set; } = 2;
        public static int ShipToJobID { get; set; } = 1;

        //Constants for versions
        public static string ConfigVersion { get; } = "C";
        public static string PlannedShipDateversion { get; } = "D";
        public static string ToolVersion { get; } = "T";
        public static string ShipToBase { get; } = "SHIP TO BASE";
        public static string ShippedTools { get; } = "Shipped tools cannot be updated";
        public static string NoChildTools { get; } = "Child Tool Not found";
        public static string ShiipedReleasedTools { get; } = "Tools in Shipped/Released status cannot be changed";
        public static string ToolStatus { get; } = "Tool Status";
        public static string NoRowsUpdated { get; } = "No rows were updated for cancel entire TCO";
        public static string PartialStatus { get; } = "Partially ";
        public static string ProductlineEntry { get; } = "Product line entry for this Tool";
        public static string NotFound { get; } = "is not found ";
        public static string HyphenSymbol { get; } = "-";
        public static string ServiceDeliveryManager { get; } = "Service delivery manager";
        public static string FieldServiceManager { get; } = "field service manager";
        public static string blockuidefaultmsg { get; } = "Page load is in progress.";

        //Job State//
        public static string JOB_STATUS_PLANNED { get; } = "Planned";
        public static string JOB_STATUS_ACCEPTED { get; } = "ACCEPTED";
        public static string JOB_STATUS_REDIRECTED { get; } = "REDIRECTED";
        public static string JOB_STATUS_SUBMITTED { get; } = "SUBMITTED";
        public static string JOB_STATUS_REJECTED { get; } = "REJECTED";
        public static string JOB_STATUS_RELEASED { get; } = "RELEASED";
        public static string JOB_STATUS_SHIPPED { get; } = "SHIPPED";
        public static string JOB_STATUS_CANCELLED { get; } = "CANCELLED";
        public static string JOB_STATUS_COMPLETED { get; } = "COMPLETED";
        public static string JOB_STATUS_RESTORED { get; } = "RESTORED";
        public static string RTO_STATUS_CREATED { get; } = "CREATED";
        public static string RTO_STATUS_CANCELLED { get; } = "CANCELLED";

        public static string DateFormat_ddMMMyyyyHHmm { get; } = "dd-MMM-yyyy HH:mm";
        public static string ShowError { get; } = "SHOW_ERROR";
        public static string TCO_NAME { get; set; } = "TCO";
        public static string ConstantTco { get; } = "TCO: ";
        public static string ConstantLockedby { get; } = " has been locked by ";
        public static string ConstantLocation { get; } = " from location ";
        public static string DateFormat_ddMMMyyyy { get; } = "dd-MMM-yyyy";
        public static string ContactLocalAdmin { get; } = ". Please contact Local Administrator for unlocking the TCO";
        public static string ConstantAcquire { get; } = "ACQUIRE_LOCK";
        public static string ConstantTRO { get; } = "TRO: ";
        public static string TROName { get; set; } = "{0}-{1}-{2}";
        public static string TCOName { get; set; } = "{0}-{1}-{2}-{3}";
        public static string ConstantFrom { get; } = " from ";
        public static string ConstantOn { get; } = " on ";
        public static string ConstantLocalTro { get; } = " . Please contact Local Administrator for unlocking the TRO. ";
        public static string LOADOUT_TOOL_OPTIONS { get; } = "LOADOUT_TOOL_OPTIONS";
        public static string R_TOOL_OPTION_LISTS { get; } = "R_TOOL_OPTION_LISTS";
        public static string ReportPOrdDisp { get; } = "&pOrdDisp=";
        public static string ReportparamSiteCode { get; } = "&paramSiteCode=";
        public static string ReportparamSiteId { get; } = "&paramSiteId=";
        public static string Reportpdp { get; } = "&pDP=";
        public static string ReportempID { get; } = "&empID=";
        public static string ReportQUERY { get; } = "  ";
        public static string ReportdispParam { get; } = "&dispParam=";
        public static string AND { get; } = "&";
        public static string VAL_REPLACE_AND { get; } = "PERCENTAGE26";
        public static string LOADOUTID { get; } = "&LOADOUT_ID=";
        public static string LDAPALIAS { get; } = "&LDAP_ALIAS=";
        public static string TCO_TEMPLATE_LINE_COMMENTS { get; } = "TCO_TEMPLATE_LINE_COMMENTS";
        public static string TCO_TEMPLATE_TOOL { get; } = "TCO_TEMPLATE_TOOL";
        public static string ADD_FROM_TCO_CREATION { get; } = "ADD_FROM_TCO_CREATION_SCREEN";
        public static string TemplateHeaderCreated { get; } = "Template Header created";
        public static string TemplateLogPrefix { get; } = "Template: ";
        public static string CreatedText { get; } = "created";
        public static string TemplateHeaderChange { get; } = "Template Header change";
        public static string ChangedText { get; } = "changed";
        public static string PermissionDeclinedForCurrentSite { get; } = "Permission declined for current site.";
        public static string TemplateNameAlreadyExists { get; } = "The template name already exists.";
        public static string ToolComments { get; } = "Tool Comments";
        public static string TemplateComponentWithComments { get; } = "Template component with comments";
        public static string TemplateComponent { get; } = "Template component ";
        public static string CommentsSetTo { get; } = "comments set to";
        public static string ActionAdded { get; } = "added";
        public static string TemplateComponentAdded { get; } = "Template component added";
        public static string AddedWithComments { get; } = "added with comments :";
        public static string UnsuccessfulPLUpdation { get; } = "Unsuccessful PL details updation.";
        public static string UnsuccessfulToolUpdation { get; } = "Unsuccessful Tool details updation.";
        public static string TemplateTool { get; } = "Template Tool";
        public static string AnInstanceOf { get; } = "An instance of ";
        public static string PARENT_FILTER { get; } = "ParentFilter";
        public static string CONFIGURATION { get; } = "configuration";
        public static string EVENT_TCO_HDR_SUBMISSION = "TCOSubmit";

        public static string EVENT_TCO_HDR_DEFAULT_REDIRECTION = "TcoDefaultRedirection";

        public static string EVENT_TCO_HDR_ADDITION = "TcoAddition";

        public static string EVENT_TCO_HDR_MODIFICATION = "TcoModification";

        public static string EVENT_TCO_SUBMIT = "Submit";
        public static string EVENT_TCO_TOOL_ADDITION = "Add Tool";
        public static string EVENT_TCO_TOOL_MODIFICATION = "Modification";
        public static string EVENT_TCO_DEFAULT_REDIRECT = "Default Redirect";
        public static string ADD = "Add";
        public static string IN_PROGRESS = "InProgress";
        public static string MODULE_OTHER = "Other";
        public static string TCOOption { get; } = "TCO Attribute";
        public static string R_TCO_CONFIGURATION { get; } = "R_TCO_CONFIGURATION";

        public static string QTrac { get; } = "QTrac";
        public static string ErrorSaveAsTemplate { get; } = "Unable to save template data.";
        public static string PlanningJobSheet { get; } = "PlanningJobSheet";
        public static string LoadoutIdString { get; } = "LOADOUT_ID = ";
        public static string LdapAliasString { get; } = "LDAP_ALIAS = ";
        public static string EmployeeNoString { get; } = "EMPLOYEE_NO = ";
        public static string Permissions { get; } = "Tool Collar Order";
        public static string RestoreLowerCase { get; } = "Restore";
        public static string CreatedLowerCase { get; } = "Created";
        public static string Deleted { get; } = "DELETED";
        public static string POWERPULSE { get; } = "POWERPULSE";
        public static string IMPULSE { get; } = "IMPULSE";
        public static string SLIMPULSE { get; } = "SLIMPULSE";
        public static string SHORTPULSE { get; } = "SHORTPULSE";
        public static string TELESCOPE { get; } = "TELESCOPE";
        public static string DIGISCOPE { get; } = "DIGISCOPE";
        public static string DVDXT200_6_75 { get; } = "DVDXT200 6”75";
        public static string DVDxT200_4_75 { get; } = "DVDxT200 4”75";
        public static string SingleSpace { get; } = " ";
        public static string WBM { get; } = "WBM";
        public static string OBM { get; } = "OBM";
        public static string SOBM { get; } = "SOBM";
        public static string PETROFREE { get; } = "PETROFREE";
        public static string RHELIANT { get; } = "RHELIANT";
        public static string WARP { get; } = "WARP";
        public static string NOVADRILL { get; } = "NOVADRILL";
        public static string ToolInstance { get; } = "Tool Instance";
        public static string HoleSize { get; } = "HOLE SIZE";
        public static string TCO_NAME_SIZE { get; set; } = "0000";
        public static string Comments { get; } = "COMMENTS";
        public static string VERSIONNUMBER { get; } = "VERSION NUMBER";
        public static string SHIPDATE { get; } = "SHIP DATE";
        public static string SHIPDATESTATUS { get; } = "SHIP DATE STATUS";
        public static string SHIPPINGINSTRUCTION { get; } = "SHIPPING INSTRUCTION";
        public static string DOCKPHONE { get; } = "DOCK PHONE";
        public static string DOCKNAME { get; } = "DOCK NAME";
        public static string JOBPROBABILITY { get; } = "JOB PROBABILITY";
        public static string BOREHOLE { get; } = "BORE HOLE";
        public static string MonelID { get; } = "Monel ID";
        public static string Tool { get; } = "Tool";
        public static string ToolParameter { get; } = "TOOL PARAMETER";
        public static string TOOL_OPTION { get; } = "TOOL_OPTION";
        public static string SHIP_TO_JOB { get; } = "SHIP TO JOB";
        public static string TelemetryMisMatchMsg { get; } = "'{0}' in the TCO do not match the signal prediction input values. Do you want to update the TCO parameters?";
        public static string TelemetryImportSuccess { get; } = "Telemetry results imported successfully.";
        public static string ToolName { get; } = "Tool Name";
        public static string DTR { get; } = "DTR";
        public static string DTNR { get; } = "DT&R";
        public static string PARTIALLYACCEPTED { get; } = "PARTIALLY ACCEPTED";
        public static string toolorder { get; } = "Tool Order";
        public static string Edit { get; } = "Edit";
        public static string UnableToUpdateTcoHeaderParams { get; } = "Unable to update the TCO header data. Please try again.";
        public static string UnableToUpdateTcoToolOptions { get; } = "Unable to update the TCO tool options data. Please try again.";
        public static string UnableToUpdateSignalStrength { get; } = "Unable to update the signal strength. Please try again.";
        public static string TCOCreation { get; } = "TCOCreation";
        public static string EMPLOYEE_NO { get; } = "&EMPLOYEE_NO=";
        public static string MMARotorType { get; } = "MMA Rotor Type";
        public static string MMAGap { get; } = "MMA Gap";
        public static string TelemetryMode { get; } = "Telemetry Mode";
        public static string IPTAFlowRange { get; } = "IPTA Flow Range";
        public static string TelemetryMethod { get; } = "Telemetry Method";
        public static string FlowRange { get; } = "Flow Range";
        public static string XMAGap { get; } = "XMA Gap";
        public static string TelemetryErrorString { get; } = " - Use &lt;{0} xsi:nil=\"true\"/&gt; for input empty value.";
        public static string UlStartElement { get; } = "<ul>";
        public static string UlEndElement { get; } = "</ul>";
        public static string TelemetryErrorMsg { get; } = "  There are few more invalid elements to correct...";
        public static string LiStartElement { get; } = "<li>";
        public static string LiEndElement { get; } = "</li>";
        public static string SUBMIT_UPDATE_SERIALIZED_ASSETS { get; } = "TCOPUTSERIALIZEDASSETS";


        public static string PLANNED_SHIPPED_DATE { get; } = "Planned Shipped Date";
        public static string PDArcher { get; } = "PD Archer";
        public static string TblRefWoErrorCode { get; } = "tblRefWOErrorCode";

        public static string TOOL_HIERARCHY_KEY = "toolHierarchyKey";
        #region Column Name Constants (R_MASTER_ATTRIBUTE table --> Name column)
        //Constats for Column Names to be used for specific conditions or validations
        //Need to verify TCOHeaderData Properties also
        //Need to verify TcoHeaderAttributes enum
        //toolconfiguration.Component.js

        public static string MUD_TYPE { get; } = "MUD_TYPE";
        public static string MONITORING_COMPANY { get; } = "MONITORING_COMPANY";
        public static string INSPECTION_COMPANY { get; } = "INSPECTION_COMPANY";
        public static string INSPECTION_LEVEL { get; } = "INSPECTION_LEVEL";
        public static string INSPECTION_PAPERWORK { get; } = "INSPECTION_PAPERWORK";
        public static string START_DEPTH_MD { get; } = "START_DEPTH_MD";
        public static string END_DEPTH_MD { get; } = "END_DEPTH_MD";
        public static string END_DEPTH_TVD { get; } = "END_DEPTH_TVD";
        public static string SEA_DEP { get; } = "SEA_DEP";
        public static string PLANNED_FLOW_RATE { get; } = "PLANNED_FLOW_RATE";
        public static string PLANNED_FLOW_RATE_MIN { get; } = "PLANNED_FLOW_RATE_MIN";
        public static string INCLINATION { get; } = "INCLINATION";
        public static string Max_Mud_Den { get; } = "Max_Mud_Den";
        public static string MUD_VISCOSITY { get; } = "MUD_VISCOSITY";
        public static string BHT { get; } = "BHT";
        //public static string BHP { get; } = "BHP";
        public static string HIGH_PRESSURE { get; } = "HIGH_PRESSURE";
        public static string HIGH_TEMPERATURE { get; } = "HIGH_TEMPERATURE";
        public static string TRUCKING_COMPANY { get; } = "TRUCKING_COMPANY";
        public static string Mag_Spacing { get; } = "Mag_Spacing";
        public static string DOGLEG { get; } = "DOGLEG";
        public static string HIGH_CORROSIVE { get; } = "HIGH_CORROSIVE";
        public static string HIGH_SHOCK { get; } = "HIGH_SHOCK";
        public static string Max_DLS { get; } = "Max_DLS";
        public static string BH_Static_Temperature { get; } = "BH_Static_Temperature";
        public static string SURF_TEMP { get; } = "SURF_TEMP";
        public static string MUD_PV_TEMP { get; } = "MUD_PV_TEMP";
        public static string STAND_PRESS { get; } = "STAND_PRESS";
        public static string MUD_PV { get; } = "MUD_PV";
        public static string TCO_PRIORITY { get; } = "TCO_PRIORITY";
        public static string MAXWELL { get; } = "MAXWELL";
        public static string RX_5By6 { get; } = "RX_5/6";
        public static string HSPM { get; } = "HSPM";
        public static string Bit_Type { get; } = "Bit_Type";
        public static string LWD_EXTENDERS_REQ { get; } = "LWD_EXTENDERS_REQ";
        public static string DTR_Activation_System_8000_9250 { get; } = "DTR_Activation_System_8000_9250";
        public static double INCLINATION_MATH_VALUE { get; } = 57.29;
        public static double MUD_DENSITY_MATH_VALUE { get; } = 1000;
        public static double MUD_PV_MATH_VALUE { get; } = 0.05;
        public static double TEMPERATURE_MATH_VALUE { get; } = 273.15;
        public static double PLANNED_FLOW_RATE_MATH_VALUE { get; } = 3600.0;
        public static double STAND_PRESS_MATH_VALUE { get; } = 101325;


        //Quest
        public static string QUEST_EXEMPTION_STATUS_APPROVED = "Approved";
        public static string TCOLIST_COMPLETED { get; } = "Completed";
        public static string TCOLIST_CANCELLEDNONSLB { get; } = "CancelledNonSLB";

        //BHA
        public static string UH_CONNECTION_SIZE = "UH Connection Size";
        public static string UH_CONNECTION_TYPE = "UH Connection Type";
        public static string DH_CONNECTION_SIZE = "DH Connection Size";
        public static string DH_CONNECTION_TYPE = "DH Connection Type";

        public static string MASTER_LOCATION = "Master";
        #endregion
        //ajain16
        public static string Type_Change = "Config Changes";
        public static string QUANTITY = "Quantity";
        public static string FOOTER_DATE_FORMAT = "dd-MMM-yyyy hh:mm";

        #region TCO Admin Constants

        public static string TCO_ADMIN_OBJECT = "TCO Admin";
        public static string TCO_ADMIN_PERM = "EDIT";
        public static string ADMIN_ERROR_PATH_KEY = "TCOAdminErrorPath";
        public static string MAST_ATTR_SAVE_FAIL = "Failed to save Master Attributes";
        public static string MAST_ATTR_UPDATE_FAIL = "Failed to update Master Attributes";
        public static string MAST_ATTR_DUPLICATE = "Master Attribute already exist";
        public static string MAST_ATTR_MANDATORY = "Please fill mandatory fields : ";
        public static string MAST_VAL_SAVE_FAIL = "Failed to save Master Values";
        public static string MAST_VAL_UPDATE_FAIL = "Failed to update Master Values";
        public static string MAST_VAL_DUPLICATE = "Master Value already exist";
        public static string MAST_VAL_MANDATORY = "Please fill mandatory fields : ";
        public static string ADMIN_ACCESS_DENIED = "You do not have access to this page. Please contact an Administrator to request access";
        public static string NOT_FILED = "Not Filed";
        public static string NULL = "NULL";
        public static string TOOL_ATTR_SAVE_FAIL = "Failed to save Tool Attributes";
        public static string TOOL_ATTR_DUPLICATE = "Tool Attribute already exist (Special characters excluded for validation)";
        public static string TOOL_ATTR_DISP_ORDER_DUPLICATE = "Display order can't be same for multiple attributes";
        public static string TOOL_ATTR_MANDATORY = "Please fill mandatory fields : ";
        public static string TOOL_VAL_SAVE_FAIL = "Failed to save Tool Values";
        public static string TOOL_VAL_DUPLICATE = "Tool Attribute Value already exist";
        public static string TOOL_ATTR_UPDATE_FAIL = "Failed to save Tool Attributes";
        public static string TOOL_VAL_UPDATE_FAIL = "Failed to save Tool Attribute Values";
        public static string TOOL_ATTR_COPY_FAIL = "Failed to copy Tool Attributes";
        public static string TOOL_ATTR_COPY_DUPLICATE = "<p>Tool Attributes already exist in destination tool.<p><ul>";
        public static string TOOL_ATTR_COPY_DUPLICATE_ELE = "<li><b>{0}</b></li>";
        public static string TOOL_BHA_POS_DUPLICATE = "Tool Attribute with same position already exist";
        public static string TOOL_BHA_ATTR_MANDATORY = "Please fill mandatory fields : ";
        public static string CONTROL_PARENT_INACTIVE_ERROR = "You are not allowed to set the selected value inactive, as it is used in cascading";

        public static string TOOL_NAME_FORMAT = "{0} => {1} => {2}";

        public static int DISPLAY_WIDTH = 5;
        public static int ETRACE_ID = 0;

        public static string DEACTIVATE_FAIL = "Failed to Deactivate";
        public static string DEACTIVATE_SUCCESS = "Deactivation successful";

        public static string PROD_LINE_DUPLICATE = "The Product Line {0} already exists";
        public static string PROD_LINE_SAVE_FAIL = "Failed to save the Product Line details";
        public static string PROD_LINE_MANDATORY = "Please fill all the mandatory fields to save the Product Line details";
        public static string PROD_LINE_INACTIVE_ADD = "{0} is inactive under Drilling Group. Do you want to activate it under Drilling Group?";
        public static string PROD_LINE_INACTIVE_EDIT = "The Product Line {0} already exists and is inactive";
        public static string PROD_LINE_SAVE_SUCCESS = "Product Line Details saved successfully";
        public static string PROD_LINE_LENGTH_ERR = "Product Line name should not exceed 50 characters";
        public static string PROD_LINE_INVALID = "Invalid Product Line";

        public static string PROD_GROUP_DUPLICATE = "The Product Group {0} already exists under the Product Line {1}";
        public static string PROD_GROUP_INACTIVE_ADD = "{0} is inactive under {1}. Do you want to activate it under {2}?";
        public static string PROD_GROUP_INACTIVE_EDIT = "The Product Group {0} already exists under the Product Line {1} and is inactive";
        public static string PROD_GROUP_SAVE_FAIL = "Failed to save the Product Group details";
        public static string PROD_GROUP_MANDATORY = "Please fill all the mandatory fields to save the Product Group details";
        public static string PROD_GROUP_SAVE_SUCCESS = "Product Group Details saved successfully";
        public static string PROD_GROUP_LENGTH_ERR = "Product Group name should not exceed 50 characters";
        public static string PROD_GROUP_INVALID = "Invalid Product group";

        public static string TOOL_DUPLICATE = "The Tool {0} already exists under {1}/{2}";
        public static string TOOL_INACTIVE_ADD = "The Tool {0} is inactive under {1}/{2}. Do you want to activate it under {3}/{4}?";
        public static string TOOL_INACTIVE_EDIT = "The Tool {0} already exists under {1}/{2} and is inactive";
        public static string TOOL_SAVE_FAIL = "Failed to save the tool details";
        public static string TOOL_MANDATORY = "Please fill all the mandatory fields to save the tool details";
        public static string TOOL_SAVE_SUCCESS = "Tool Details saved successfully";
        public static string TOOL_LENGTH_ERR = "Tool name should not exceed 50 characters";

        public static string REACTIVATE_FAIL = "Reactivation failed";
        public static string REACTIVATE_SUCCESS = "Reactivation successful";
        public static int? TOOL_FSMTOOLHIERARCHYLEVEL { get; } = 5;

        public static string RIGHT = "Right";
        public static string LEFT = "Left";

        public static string GBHA_IMG_ASSOC_FAIL = "Failed to associate the graphical BHA image details";
        public static string GBHA_IMG_ASSOC_SUCCESS = "Graphical BHA image associated successfully";
        public static string GBHA_IMG_INVALID = "Invalid Graphical BHA image";
        public static string GBHA_IMG_TYPE_ERROR = "Only image with following extensions can be uploaded: JPEG, GIF, TIFF ,PNG or EMF";
        public static string GBHA_IMG_SIZE_ERROR = "Size of Attachment should not exceed 4 MB";
        public static string GBHA_IMG_WIDTH_ERROR = "Image cannot be uploaded as its more than specified width";
        public static string GBHA_IMG_FILE_EMPTY = "The file being attached is either empty or file path is invalid";
        public static string GBHA_IMG_EXISTS_MSG = "An image is already associated with the tool. Do you want to replace the existing image with the new image?";
        public static string GBHA_IMG_CONFIRM_UPLOAD = "Do you want to associate the image with the tool?";
        public static int? GBHA_MAX_IMG_WIDTH { get; } = 50;
        public static int? GBHA_MAX_IMG_SIZE { get; } = 4 * 1024 * 1024;

        public static string EXCEL_FILE_DATE_FORMAT { get; } = "yyyyMMddHHmm";
        public static string EXPORT_EXCEL_SUCCESS = "Master Attributes and Values Data exported successfully";
        public static string EXPORT_EXCEL_FAILURE = "Master Attributes and Values Data export failed";

        public static string JOB_ATTR_EXCEL_SUCCESS = "Job Attributes and Values Data exported successfully";
        public static string JOB_ATTR_EXCEL_FAIL = "Job Attributes and Values Data export failed";
        public static string TOOL_ATTR_EXCEL_SUCCESS = "Tool Attributes and Values Data exported successfully";
        public static string TOOL_ATTR_EXCEL_FAIL = "Tool Attributes and Values Data export failed";

        public static string JOB_ATTR_MANDATORY = "Please fill mandatory fields : ";
        public static string JOB_VAL_SAVE_FAIL = "Failed to save Job attribute Values.";

        public static string Dimension_Linked_Dropdown = "<div>Below {0} with control type other than <i>TEXTBOX</i> already linked for attribute {1} <br> {2} </div>";


        public static string DEFAULT_JOB_TYPE = "Default";

        public static string JOB_ATTR_SAVE_FAIL = "Failed to save Job Attributes";
        public static string JOB_ATTR_DUPLICATE = "Job Attribute already exist (Special characters excluded for validation)";
        public static string JOB_ATTR_DISP_ORDER_DUPLICATE = "Display order can't be same for multiple job attributes";
        public static string JOB_ATTR_VALUE_SORT_ORDER_DUPLICATE = "Sort order can't be same for multiple job attribute values";
        public static string TOOL_ATTR_VALUE_SORT_ORDER_DUPLICATE = "Sort order can't be same for multiple tool attribute values";
        public static int? MAX_WARNING_MSG_OPTIONS { get; } = 10;
        public static string Hole_Size = "Hole Size";
        public static string DropDownControl = "DROPDOWNLIST";
        public static string TypeaheadControl = "TYPEAHEADDROPDOWN";
        public static string TextBoxControl = "TEXTBOX";
        public static int HoleSizeId = -1;
        public static string JOBS = "Jobs";
        public static string TOOLS = "Tools";
        public static string HoleSizeHeader = "HoleSize Header";
        public static string TCOHeader = "TCO Header";
        public static string BothHeaders = "Both Headers";
        public static string CASCADE_MAP_FAIL = "Failed to save the mapping details";
        #endregion
        public static string Status_InActive = "InActive";
        public static string CASCADING_TEXT_VALIDATION = "Multiple text values are not allowed for each parent master value!";
        public static string Dummy = "DUMMY";
        public const int maxToolSeqCount = 2;
        public const int maxTcoSeqCount = 3;
        public static string JunkString = "? string:";
        public static char QuestionMark = '?';
        #region GTScan Constants
        public static string successStatus = "Success";
        public static string minimumDate = "1900-01-01 00:00:00.000";
        public static string failStatus = "Fail";
        public static string assetIDValidation = "AssetId is mandatory";
        public static string RMISYes = "YES";
        public static string RMISNo = "NO";
        public static string containsNonTCOMessage = "Shipment also contains Non-TCO equipment, for which shipping details have not been displayed";
        public static string containsOnlyNonTCOMessage = "Shipment contains only Non-TCO equipment, so no shipping details displayed";
        public static string JOBTOBASE = "JOB - BASE";
        public static string baseToBase = "BASE - BASE";
        public static string mandatoryValidation = "FTL Shipment Number or Shipment Number is mandatory";
        public static string NoresultValidation = "No records found for the given search criteria";
        public static string VALIDMOVEMENTTYPE = "Both ShipmentNumber and FTLShipmentNumber should not be passed as an Input";
        public static string Rejected = "Rejected";
        public static string Received = "Received";
        public static string Receive = "Receive";
        public static string Reject = "Reject";
        public static string InProgress = "In Progress";
        public static string VALIDINPUT = "Please enter valid input";
        public static string Shipment_Object = "Shipment";
        public static string Shipment_Permission = "User doesn't have permission for shipment for current site";
        public static string Destination_Inactive = "Movement cannot be processed since the destination site is not active";
        public static string ShipmentDate_Mandatory = "Shipment date is mandatory";
        public static string PermissionType_NEW = "NEW";
        public static string PermissionType_EDIT = "Edit";
        public static string MovementAlreadyDeleted = "This shipment record has been deleted by another user. Cannot complete this operation.";
        public static string MovementAlreadyReceived = "This Shipment/Transfer has already been dispatched by another user. Cannot complete this operation.";
        public static string Tro = "This is a TRO.Please use QTrac Web App to ship the TRO to Base";

        public static string TCO_SUBMITTED = "SUBMITTED";
        public static string TCO_REJECTED = "REJECTED";
        public static string TCO_ACCEPTED = "ACCEPTED";
        public static string TCO_RELEASED = "RELEASED";
        public static string TCO_SHIPPED = "SHIPPED";
        public static string TCO_REDIRECTED = "REDIRECTED";
        public static string TCO_CANCELLED = "CANCELLED";
        public static string TOOl_COMMENTS = "Tool Comments";
        public static string SHIPPING_INSTRUCTIONS = "Shipping Instructions";
        public static string tcoSearchMandatoryValidation = "Transaction site is mandatory (Ex:NGCTLM)";
        public static string tcoSearchNoresultValidation = "No records found for the given search criteria";
        public static string tcoDataSearchNoresultValidation = "No TCO Details found for this TCO";
        public static string tcoSearchOtherMandatoryValidation = "Please give value for any field along with the Transaction Site";

        public static string transferInRecMandatoryValidation = "Shipment Number is mandatory for Transfer-In Receive/Cancel Shipment";
        public static string transferInRecMandatoryValidationReceivedDt = "Received Date is mandatory for Transfer-In Receive/Cancel Shipment";
        public static string transferInRecMandatoryValidationReceivedBy = "Received By is mandatory for Transfer-In Receive/Cancel Shipment";
        public static string transferInRecMandatoryValidationAssetNo = "Asset Number is mandatory for Transfer-In Receive/Cancel Shipment";
        public static string transferInRecMandatoryValidationReceiveSt = "Receive Status should be either Accept or Reject";
        public static string transferInRecNoShipDetailsValidation = "There are no Shipment Details for the given Shipment Number";
        public static string transferInRecNoShipDetailsValidationComments = "Transfer-In Cancel Comments are mandatory for Cancel";
        public static string transferInRecValidationRMIS = "Shipment contains RMIS equipment, please process it manually from QTrac web application";
        public static string transferInRecValidationTCOHOLD = "TCO Transfer Type is Ship & Hold, please process it manually from QTrac web application";

        public static string TRANSFERTYPE_HOLD = "HOLD";
        public static string TRANSFERTYPE_PERMANENT = "PERMANENT";
        public static string TransferIn_ReceiveSt_Reject = "Reject";
        public static string TransferIn_ReceiveSt_Accept = "Accept";
        public static string TransferIn_ReceiveACTION = "Change";
        public static string WOT_ST_PUBLISHED = "Published";
        public static string WOT_TEMPLATE_TYPE_SL = "Service Level";

        public static string BASE = "BASE";
        public static string REROUTE = "REROUTE";
        public static string TRANSFERREROUTE = "Transfer Reroute";
        public static string TRANSFERINOUT = "Transfer (In/Out)";
        public static string SHIPDATEFORMAT = "dd MMM yyyy  h:mmtt";
        public static string RECEIVESHIPDATEFORMAT = "MM/dd/yy hh:mm:ss tt";
        public static string DateyyymmddhhmmssFormat = "yyy-MM-dd HH:mm:ss";

        public static string WO_STATUS_OPEN = "OPEN";
        public static string WO_STATUS_ASSIGNED = "ASSIGNED";
        public static string WO_STATUS_RELEASED = "RELEASED";
        public static string WO_STATUS_IN_PROGRESS = "IN PROGRESS";
        public static string WO_STATUS_COMPLETED = "COMPLETED";
        public static string SRC_TRIGGER_TYPE = "Movement";
        public static string WO_TYPE_DESC = "Toolset";
        public static string PRIORITY_DESC = "MEDIUM";

        public static string EQP_STATE_FXD = "FIXED";
        public static string EQP_STATUS_ASSEMBLED = "ASSEMBLED";
        public static string TRANSFER_IN_RECEIVE_TRAN_REMARKS= "Transfer to Base - Receive";
        public static string TRANSFER_IN_RECEIVED_ALREADY="This item is already received";
        public static string TRANSFER_IN_RECEIVED_MESSAGE = "Item received successfully";
        public static string TRANSFERIN = "Transfer In";
        public static string EQPSTATE_TRANFRD = "Transferred";

        public static string COMPLETED_STATUS = "IMPORTED";
        public static string PENDING_IMPORT_STATUS = "PENDING IMPORT";

        public static string EQUIP_STATE_RITE = "RITE";
        public static string EQUIP_STATUS_RFF = "RFF";

        public static string DEFAULT_DATE = "1/1/0001 12:00:00 AM";

        public static string REQUEST_TCONUMBER = "TCONumber";
        public static string REQUEST_DISPATCHDATE = "DispatchDate";
        public static string REQUEST_DISPATCHEDBY = "DispatchedBy";

        public static string MSG_SOURCE_SITE_DEACTIVE = "Movement cannot proceed since the source site is not Active.";
        public static string MSG_MANDATORY_INPUT = " are mandatory.";
        public static string MSG_MANDATORY_SINGULAR_INPUT = " is mandatory.";
        public static string MSG_UNLINKED_TOOLS = "All tools must be linked with Equipment in RITE State & RFF Status.";
        public static string MSG_EQUIPS_NOTIN_RITERFF = " are not in RITE RFF state to ship";
        public static string MSG_TCO_ALREADY_SHIPPED = "TCO was already shipped";
        public static string MSG_TCO_NoTools = "No tools are found to shipped";
        public static string MSG_PARTIAL_SHIPMENT = "Partial TCO Shipments are not allowed through GT. Please process manually from QTrac web application.";
        public static string MSG_RELEASED_TOOLS = "The Tool Order for the following equipments must be RELEASED before the shipment can be dispatched ";
        public static string MSG_DISPATCH_RANGE="Dispatch date should be in between {0}";
        public static string MsgDispatchDateTimeRange = "Dispatch date should be in between {0} (UTC)";
        public static string MSG_INVALID_TCONUMBER = "Invalid TCO Number";
        public static string MSG_INVALID_DISPATCHEDBY = "Invalid Dispatched By";
        public static string MSG_SHIPMENT_PRIOR = "Shipment date/time is prior to last shipment on the equipment {0}.Please correct conflict";
        public static string MSG_SHIPMENT_ONEHOURSHIP = "Only one shipment can be done in an hour for the equipment {0}.Please select a time one hour later than {1}";
        public static string MSG_TIME_REQ = "Please enter valid time in DispatchDate";
        public static string MSG_INVALID_ASSET = " is invalid asset.";
        public static string MSG_INVALID_ASSETS = " are invalid assets.";
        public static string MSG_NOT_LINKED_TCO_ASSET = " is not a part of this TCO. Please provide a valid Asset ID";
        public static string MSG_NOT_LINKED_TCO_ASSETS = " are not a part of this TCO. Please provide a valid Asset IDs";
        public static string MSG_ENTER_ASSET_ID = "Please enter valid Asset Id";

        public static string MSD_DISPATCH_SUCCESS= "Dispatch Done Successfully";

        public static string MSG_INTERNAL_ERROR = "Failed to ship a TCO due to internal server error.";
        public static string MSG_LASTSHIPMENT_PRIOR= "Shipment date/time is prior to last shipment on the equipment.Please correct conflict";
        public static string MSG_SHIPMENT_ONEHOUR = "Only one shipment can be done in an hour.Please select a time later than {0}";
        public static string receiveShipmentRecMandatoryValidation = "FTL Shipment Number is mandatory for Receive/Reject Shipment";
        public static string receiveShipmentRecMandatoryValidationReceivedDt = "Received Date is mandatory for Receive/Reject Shipment";
        public static string receiveShipmentRecMandatoryValidationReceivedBy = "Received By is mandatory for  Receive/reject Shipment";
        public static string receiveShipmentRecMandatoryValidationAssetNo = "Asset Number is mandatory for Receive/Reject Shipment";
        public static string receiveShipmentRecMandatoryValidationReceiveSt = "Receive Status should be either Accept or Reject";
        public static string receiveShipmentRecNoShipDetailsValidation = "LineIDs are mandatory";
        public static string receiveShipmentAllowsOnlyJobToBase = "Only JOB - Base shipments are allowed";
        public static string MSG_SHIPMENT_RANGE = "Shipment Receive Date should be between ";
        public static string UTC_Time_Zone = "(UTC)";
        public static string ftlShipmentNumberNotValid = "Please provide a valid FTL shipment number";
        public static string shipmentNumberNotValid = "Please provide a valid shipment number";
        public static string FTL_JOB_BASE_ONLY = "Only Job to Base transactions are allowed";

        public static string TRANSFER_IN_NORECORDS = "No Records found for the given Shipment Number";


        public static string TcoCancelShipmentRequest = "TCOCANCELSHIPMENTREQUEST";
        public static string CancelTransferRemarks = "Site updated as transfer cancelled";

        public static string EquipmentStateRong = "RONG";
        public static string EquipmentStateFxd = "FXD";
        public static string EquipmentStatusUsed = "USED";
        public static string EquipmentStatusAssembled = "ASSEMBLED";
        public static string CancelShipmentReqXML = "<configuration><CancelShipmentRequest MovementHdr_ID={0} createdBy={1} CreatedDate={2}/></configuration>";

        public static string ErrMsgInvalidShipmentNo = "Shipment number does not exists in Qtrac";
        public static string ErrMsgShipmentReceived = "This Shipment has been already Received";
        public static string ErrMsgNotBaseToBase = "Movement FromType and ToType is not BASE-BASE";
        public static string ErrInvalidCommentReason = "Invalid Comment Reason";
        public static string ErrUpdatingSiteInfo = "An error occured while updating Site information";
        public static string ErrInvalidEquipment = "Equipment is not a part of the shipment";
        public static string ReasonTypeCancelTransfer = "Transfer Cancel";
        public static string ReasonOther= "Other";
        public static string CancelSuccess = "Transfer(s) cancelled successfully";

        public static string PermissionTransferInObj = "Transfers In";
        public static string PermissionTransferInRECDesc = "RECEIVE";
        public static string PermissionTransferInCancelDesc = "CANCEL TRANSFER";

        public static string NoRecPermissionTransferIn = "User doesn't have Receive Permission for TransferIn";

        public static string NoCancelPermissionTransferIn = "User doesn't have Cancel Permission for TransferIn";

        public static string Msg_EquipmentPartOfAnotherShipment = "The Equipment is part of another Shipment. Please remove it from this Shipment.";
        public static string Msg_ToolSetPartOfAnotherShipment = "The ToolSet is part of another Shipment. Please remove it from this Shipment.";
        public static string Msg_EquipmentInDiffJob = "The Equipment is not in currently selected JOB. Please remove it from this Shipment.";
        public static string Msg_ToolSetInDiffJob = " The ToolSet is not in currently selected JOB. Please remove it from this Shipment.";
        public static string RejectedComment = "{0}.{1} was not received";
        public static string Msg_ReceivedFromGT_ReceiveReject = "Rejection of Asset(s) {0} are done from GT - ";
        public static string Msg_ReceivedFromGT_Receive = "Receiving of Asset(s) {0} are done from GT - ";
        public static string Msg_ReceivedFromGT_TransferIn = "Transfer-in of Asset(s) {0} are done from GT - ";
        public static string Msg_ReceivedFromGT_ShipmentOut = "ShipmentOut of Asset {0} are done from GT - ";
        public static string Msg_TransferIn_Failure_GT = "Transfer-In was done SuccessFully. But issue while inserting Comments";
        public static string Priority_Medium = "MEDIUM";
        public static string MSG_RECEIVED_SUCCESS = "Item received successfully";
        public static string MSG_REJECTED_SUCCESS = "Item rejected successfully";
        public static string JOB = "JOB";
        public static string NEW = "New";
        public static string PendingReceive = "Pending Receive";
        public static string Msg_Equipment_ReceivedOrRejected = "The Equipment is already received/rejected as part of another movement";
        public static string Msg_Equipment_Not_In_FTLShipment = "This Asset is not a part of the given FTL Shipment Number";
        public static string Msg_Equipment_Not_In_Shipment = "This Asset is not a part of the given Shipment Number";
        public static string NEW_STATUS = "NEW";
        public static string COMPLETE_STATUS = "COMPLETE";
        public static string MOVEMENT_COMPLETED_STATUS = "COMPLETED";
        public static string IN_PROGRESS_STATUS = "IN PROGRESS";
        public static string COMPLETE_WITHREJECTION_STATUS = "COMPLETE WITH REJECTIONS";
        public static string TOOLSET_WO = "Toolset WO";
        public static string TOOLSET = "Toolset";
        public static string TOOLSET_CALIBRATION = "Toolset Calibration";
        public static string Movement_Job_To_Base="Movement Job To Base";
        public static string Movement = "Movement";
        public static string ACCEPT = "ACCEPT";
        public static string IN_PROCESS = "IN PROCESS";
        public static string Return_Shipment_Processing="Return Shipment Processing";
        public static string TCO_SERIALIZED_ASSETS_MODULE = "TCOPUTSERIALIZEDASSETS";
        public static string TRANSFER_IN_RECDATEMSG = "Receive date cannot be less than Transfer date. Please change Receive date to proceed further!!!";
        public static string TransferStatusImported = "Imported";
        public static string TransferStatusPendingImport = "Pending Import";
        public static string TransferStatusCancelled = "Cancelled";

        public static string FILECODE_SERIALNO= "File Code.Serial No = ";
        public static string MSG_NOT_LINKED_ASSET1 = "The following Asset(s) are not a part of this TCO: ";
        public static string Msg_FileCode_Not_Belon_SameSite = "Asset(s) {0} belongs to site {1}.";
        public static string Msg_Pass_Eqp_Same_Site = "Please pass equipments of same site.";
        public static string MSG_NOT_LINKED_ASSET2 = ". Please provide a valid input.";
        #endregion
        public static string specialCharPattern = @"[^0-9a-zA-Z]+";

        #region FMPConstants
        public const string FmpParameter = "PARAMETER";
        public const string FmpToolorder = "TOOL ORDER";
        public const string FmpToolorderstatus = "TOOL ORDER STATUS";
        public const string FmpToolordercomments = "TOOL ORDER COMMENTS";
        public const string FmpToolorderdepartmentstatus = "TOOL ORDER DEPARTMENT STATUS";
        public const string FmpTool = "TOOL";
        public const string FmpToolparameter = "TOOL PARAMETER";
        public const string FmpCheckboxoption = "CHECKBOX OPTION";
        public const string FmpTextboxoption = "TEXTBOX OPTION";
        public const string FmpDropdownlistoption = "DROPDOWNLIST OPTION";
        public const string FmpNumericoption = "NUMERIC OPTION";
        public const string FmpMultilineoption = "MULTILINE OPTION";
        public const string FmpToolinstance = "TOOL INSTANCE";
        public const string FmpTro = "TRO";
        public const string FmpToolstatus = "TOOL STATUS";
        public const string FmpToolcomments = "TOOL COMMENTS";
        public const string FmpTemplateheadercreated = "TEMPLATE HEADER CREATED";
        public const string FmpTemplateheaderchange = "TEMPLATE HEADER CHANGE";
        public const string FmpTemplatecomponentadded = "TEMPLATE COMPONENT ADDED";
        public const string FmpTemplatecomponentwithcomments = "TEMPLATE COMPONENT WITH COMMENTS";
        public const string FmpTemplatecomponentaddedwithcomments = "TEMPLATE COMPONENT ADDED WITH COMMENTS";
        public const string FmpTemplatetool = "TEMPLATE TOOL";
        public const string FmpTemplatecomponentdeleted = "TEMPLATE COMPONENT DELETED";
        public const string FmpTemplatetooldeleted = "TEMPLATE TOOL DELETED";
        public const string FmpTemplatestatus = "TEMPLATE STATUS";
        public const string FmpEmptyspace = " ";
        public const string FmpFullstop = ".";
        public const string FmpSplit = "SPLIT";
        public const string FmpDtlToolOrderComponent = "Tool Order Component ";
        public const string FmpDtlStatusSetTo = " status set to ";
        public const string FmpDtlCommentsSetTo = "  comments set to ";
        public const string FmpDtlDepartmentStatusSetTo = "  department status set to ";
        public const string FmpDtlTool = "Tool";
        public const string FmpDtlCheckBoxOption = "CheckBox Option ";
        public const string FmpDtlTextBoxOption = "TextBox Option ";
        public const string FmpDtlDropDownListOption = "DropDownList Option ";
        public const string FmpDtlMultilineOption = "Multiline Option ";
        public const string FmpDtlNumericOption = "Numeric Option ";
        public const string FmpDtlAnInstanceOf = "An instance of ";
        public const string FmpDtlAdded = "ADDED";
        public const string FmpDtlDeleted = "DELETED";
        public const string FmpDtlToolStatusof = "Tool Status of ";
        public const string FmpDtlWithComments = " with comments : ";
        public const string FmpDtlTemplatecomponent = "TEMPLATE COMPONENT  ";
        public const string FmpDtlOption = "Option ";
        public const string FmpToolOrderException = "Tool order does not exist";
        public const string FmpLdapValidation = "Please provide at least one ldap ";
        public const string YYYMMDDFormat = "yyy-MM-dd HH:mm:ss.fff";
        public const string FmpUserCheck = "User does not exist";
        public const string ApplicationName = "Qtrac";
        public const string SourceSystemId = "QTrac";
        public const int ProductLineLevel = 5;
        public const int ProductGroupLevel = 6;
        public const int ProductToolLevel = 7;
        public const string ParentLoadOutName = "System Parent Record Id";
        public const string ParentToolOrderName = "Parent EDP";
        public const string MaintenanceComments = "MaintenanceComments";
        public const string CommentsAttr = "Comments";
        public static string JOB_STATUS_CANCELLEDNONSLB { get; } = "CANCELLEDNONSLB";

        #endregion

        #region SCMConstants

        public static string SCMSoftwareVer = "Software Version";
        public static string SCMAddition= "SCM Addition";
        public static string SCMModification = "SCM Modification";
        public static string SCMAttribute = "<SCMATTRIBUTE><Value {0}/></SCMATTRIBUTE>";
        public static string SCMTrue = "True";
        public static string SCMFalse = "False";
        #endregion

        public const string LoadOutIdsTableType = "@LoadOutIdsTableType";
        public const string LoadOutId = "LoadOutId";
        public const string EditPermission = "EDIT";
        public const string SuccessMessage = "Data Saved Successfully.";
        public const string InvalidToolOrder = "QTERR0110";
        public const string ActualShipErrorCode = "QTERR0108";
        public const string UpdatePgplErrorCode = "QTERR0109";
        public const string UpdateRmShipDateErrorCode = "QTERR0111";
        public const string UpdatePlannedShipDateErrorCode = "QTERR0112";
        public const string UpdateEdpAttrErrorCode = "QTERR0117";
        public const string TcoComments = "Comments";
        public const string ShippingInstructions = "ShippingInstructions";
        public const string CommentsFailed="Saving Comments Failed";
        public const string Cancelled = "Cancelled";
        public const string CancelledNonSlb = "CancelledNonSLB";
        public const string Completed = "Completed";
        public const string Shipped = "Shipped";
        public const string Accepted = "Accepted";
        public const string ShipToJob = "Ship to Job";
    }
}