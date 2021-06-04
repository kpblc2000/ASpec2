﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASpecCore.Models.Data
{
    public partial class NPConDataModel : DbContext
    {
        public NPConDataModel()
            : base(Properties.Settings.Default.NPConConnectionString)
        {
        }

        public virtual DbSet<album> album { get; set; }
        public virtual DbSet<allLayer> allLayer { get; set; }
        public virtual DbSet<angle> angle { get; set; }
        public virtual DbSet<arm> arm { get; set; }
        public virtual DbSet<arm_type> arm_type { get; set; }
        public virtual DbSet<btn_groupname_dic> btn_groupname_dic { get; set; }
        public virtual DbSet<classType> classType { get; set; }
        public virtual DbSet<cmd_alias> cmd_alias { get; set; }
        public virtual DbSet<cmd_groups> cmd_groups { get; set; }
        public virtual DbSet<cmd_lisp> cmd_lisp { get; set; }
        public virtual DbSet<cmd_user_lisp> cmd_user_lisp { get; set; }
        public virtual DbSet<cmd_userdomains> cmd_userdomains { get; set; }
        public virtual DbSet<cmd_userlogins> cmd_userlogins { get; set; }
        public virtual DbSet<cmd_users> cmd_users { get; set; }
        public virtual DbSet<concrType> concrType { get; set; }
        public virtual DbSet<end_prod_ver_consist> end_prod_ver_consist { get; set; }
        public virtual DbSet<end_prod_ver_RawConsist> end_prod_ver_RawConsist { get; set; }
        public virtual DbSet<end_product_version> end_product_version { get; set; }
        public virtual DbSet<factory> factory { get; set; }
        public virtual DbSet<factory_lines> factory_lines { get; set; }
        public virtual DbSet<formingEquip> formingEquip { get; set; }
        public virtual DbSet<fstn_element> fstn_element { get; set; }
        public virtual DbSet<fstn_name> fstn_name { get; set; }
        public virtual DbSet<galvanized_iron> galvanized_iron { get; set; }
        public virtual DbSet<Lines> Lines { get; set; }
        public virtual DbSet<lisp_interface> lisp_interface { get; set; }
        public virtual DbSet<listalb> listalb { get; set; }
        public virtual DbSet<m_box> m_box { get; set; }
        public virtual DbSet<mark_type> mark_type { get; set; }
        public virtual DbSet<mdm_Item_modification_t> mdm_Item_modification_t { get; set; }
        public virtual DbSet<mdm_Item_modification_type_t> mdm_Item_modification_type_t { get; set; }
        public virtual DbSet<mdm_object_plain> mdm_object_plain { get; set; }
        public virtual DbSet<mod_param_value_pool> mod_param_value_pool { get; set; }
        public virtual DbSet<modification_parameter> modification_parameter { get; set; }
        public virtual DbSet<modificationType4object_type> modificationType4object_type { get; set; }
        public virtual DbSet<normdoc> normdoc { get; set; }
        public virtual DbSet<objectconsist> objectconsist { get; set; }
        public virtual DbSet<objectmark> objectmark { get; set; }
        public virtual DbSet<objectprefix> objectprefix { get; set; }
        public virtual DbSet<Objects> Objects { get; set; }
        public virtual DbSet<objecttype> objecttype { get; set; }
        public virtual DbSet<p_concr_binder> p_concr_binder { get; set; }
        public virtual DbSet<p_concr_class> p_concr_class { get; set; }
        public virtual DbSet<p_concr_comp> p_concr_comp { get; set; }
        public virtual DbSet<p_concr_frost> p_concr_frost { get; set; }
        public virtual DbSet<p_concr_waterres> p_concr_waterres { get; set; }
        public virtual DbSet<p_concrete> p_concrete { get; set; }
        public virtual DbSet<p_hdpe> p_hdpe { get; set; }
        public virtual DbSet<p_object> p_object { get; set; }
        public virtual DbSet<p_PEfilm> p_PEfilm { get; set; }
        public virtual DbSet<p_units> p_units { get; set; }
        public virtual DbSet<parameter> parameter { get; set; }
        public virtual DbSet<permission4type> permission4type { get; set; }
        public virtual DbSet<prod_work_file> prod_work_file { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<product_modification> product_modification { get; set; }
        public virtual DbSet<raw> raw { get; set; }
        public virtual DbSet<rep_prod> rep_prod { get; set; }
        public virtual DbSet<spiral_hose> spiral_hose { get; set; }
        public virtual DbSet<sql_data_type> sql_data_type { get; set; }
        public virtual DbSet<steelClasses> steelClasses { get; set; }
        public virtual DbSet<strip> strip { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_mark_code_type_C1P> tbl_mark_code_type_C1P { get; set; }
        public virtual DbSet<tbl_mark_parsing> tbl_mark_parsing { get; set; }
        public virtual DbSet<tblNodeDepth> tblNodeDepth { get; set; }
        public virtual DbSet<tblNodesContent> tblNodesContent { get; set; }
        public virtual DbSet<tube> tube { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<version_status> version_status { get; set; }
        public virtual DbSet<wood> wood { get; set; }
        public virtual DbSet<work_file> work_file { get; set; }
        public virtual DbSet<wpf_control> wpf_control { get; set; }
        public virtual DbSet<wpf_property> wpf_property { get; set; }
        public virtual DbSet<wrk_file_type> wrk_file_type { get; set; }
        public virtual DbSet<zone> zone { get; set; }
        public virtual DbSet<Assembly> Assembly { get; set; }
        public virtual DbSet<color> color { get; set; }
        public virtual DbSet<floors> floors { get; set; }
        public virtual DbSet<Geometry> Geometry { get; set; }
        public virtual DbSet<KZI> KZI { get; set; }
        public virtual DbSet<KZI_Name> KZI_Name { get; set; }
        public virtual DbSet<nomenclature> nomenclature { get; set; }
        public virtual DbSet<nomenclature_current> nomenclature_current { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<project_specific> project_specific { get; set; }
        public virtual DbSet<projects> projects { get; set; }
        public virtual DbSet<sections> sections { get; set; }
        public virtual DbSet<tblModificators> tblModificators { get; set; }
        public virtual DbSet<tblProjects> tblProjects { get; set; }
        public virtual DbSet<tblSeries> tblSeries { get; set; }
        public virtual DbSet<tbl_AspecificErrorLog> tbl_AspecificErrorLog { get; set; }
        public virtual DbSet<tbl_UserActivityLog> tbl_UserActivityLog { get; set; }
        public virtual DbSet<tbl_UserActivityStat> tbl_UserActivityStat { get; set; }
        public virtual DbSet<tbl_UserLispErrorLog> tbl_UserLispErrorLog { get; set; }
        public virtual DbSet<tbl_UserLoginForLogging> tbl_UserLoginForLogging { get; set; }
        public virtual DbSet<coloristics> coloristics { get; set; }
        public virtual DbSet<addmods_from_C1> addmods_from_C1 { get; set; }
        public virtual DbSet<albName_exep> albName_exep { get; set; }
        public virtual DbSet<aspa_entity> aspa_entity { get; set; }
        public virtual DbSet<base_ch_npcon> base_ch_npcon { get; set; }
        public virtual DbSet<base_changes_delete> base_changes_delete { get; set; }
        public virtual DbSet<cmd_log> cmd_log { get; set; }
        public virtual DbSet<factory_lines_old> factory_lines_old { get; set; }
        public virtual DbSet<factory_old> factory_old { get; set; }
        public virtual DbSet<from_view_product_dim_1_Tbl> from_view_product_dim_1_Tbl { get; set; }
        public virtual DbSet<Heater_correct> Heater_correct { get; set; }
        public virtual DbSet<IDMDM_ModId_from_1c> IDMDM_ModId_from_1c { get; set; }
        public virtual DbSet<last_changes_mark_ver> last_changes_mark_ver { get; set; }
        public virtual DbSet<lastModsMarksfrom1C> lastModsMarksfrom1C { get; set; }
        public virtual DbSet<lines_old> lines_old { get; set; }
        public virtual DbSet<loaded_Job_Files> loaded_Job_Files { get; set; }
        public virtual DbSet<loaded_Marks_from_1C> loaded_Marks_from_1C { get; set; }
        public virtual DbSet<mark_geometry> mark_geometry { get; set; }
        public virtual DbSet<Marks_and_modifications> Marks_and_modifications { get; set; }
        public virtual DbSet<Marks_and_modifications_from_EXCEL> Marks_and_modifications_from_EXCEL { get; set; }
        public virtual DbSet<Marks_and_modifications_MDMdeleted> Marks_and_modifications_MDMdeleted { get; set; }
        public virtual DbSet<Marks_and_modifications_nm> Marks_and_modifications_nm { get; set; }
        public virtual DbSet<Marks_and_modifications_to_1C> Marks_and_modifications_to_1C { get; set; }
        public virtual DbSet<mdm_forming_dimension> mdm_forming_dimension { get; set; }
        public virtual DbSet<mdm_forming_lifting> mdm_forming_lifting { get; set; }
        public virtual DbSet<mdm_Forming_type> mdm_Forming_type { get; set; }
        public virtual DbSet<mdm_Item_colour> mdm_Item_colour { get; set; }
        public virtual DbSet<mdm_Item_group_long_t> mdm_Item_group_long_t { get; set; }
        public virtual DbSet<mdm_Layer_documents_state_actual_t> mdm_Layer_documents_state_actual_t { get; set; }
        public virtual DbSet<mdm_Side> mdm_Side { get; set; }
        public virtual DbSet<MetPref> MetPref { get; set; }
        public virtual DbSet<mods_loaded_from_1c> mods_loaded_from_1c { get; set; }
        public virtual DbSet<ModsMarksfrom1C> ModsMarksfrom1C { get; set; }
        public virtual DbSet<npcon_ch_temp> npcon_ch_temp { get; set; }
        public virtual DbSet<p_object_Dev> p_object_Dev { get; set; }
        public virtual DbSet<params_loaded_from_1c> params_loaded_from_1c { get; set; }
        public virtual DbSet<product_Dev> product_Dev { get; set; }
        public virtual DbSet<some_new_mods> some_new_mods { get; set; }
        public virtual DbSet<to_SerOfMarks_t> to_SerOfMarks_t { get; set; }
        public virtual DbSet<toLocal_del> toLocal_del { get; set; }
        public virtual DbSet<WINDOWS_DOORS_to_1C> WINDOWS_DOORS_to_1C { get; set; }
        public virtual DbSet<work_file_mark_type> work_file_mark_type { get; set; }
        public virtual DbSet<Assembly_structure> Assembly_structure { get; set; }
        public virtual DbSet<nomenclature_all> nomenclature_all { get; set; }
        public virtual DbSet<view_coloristics> view_coloristics { get; set; }
        public virtual DbSet<C_v_entity_rem> C_v_entity_rem { get; set; }
        public virtual DbSet<C_v_relation_rem> C_v_relation_rem { get; set; }
        public virtual DbSet<a_view_Shelf_mark_MaxID> a_view_Shelf_mark_MaxID { get; set; }
        public virtual DbSet<ecp_wip_rem> ecp_wip_rem { get; set; }
        public virtual DbSet<entity_mark_trim_rem> entity_mark_trim_rem { get; set; }
        public virtual DbSet<ERRORS_IN_APERTURES> ERRORS_IN_APERTURES { get; set; }
        public virtual DbSet<ERRORS_IN_APERTURES_WD> ERRORS_IN_APERTURES_WD { get; set; }
        public virtual DbSet<IdObjViewNPCChExpt> IdObjViewNPCChExpt { get; set; }
        public virtual DbSet<mdm_forming_dimension_v> mdm_forming_dimension_v { get; set; }
        public virtual DbSet<mdm_forming_lifting_v> mdm_forming_lifting_v { get; set; }
        public virtual DbSet<mdm_Forming_type_v> mdm_Forming_type_v { get; set; }
        public virtual DbSet<mdm_Item_construction> mdm_Item_construction { get; set; }
        public virtual DbSet<mdm_Item_construction_Forming> mdm_Item_construction_Forming { get; set; }
        public virtual DbSet<mdm_Item_construction_modification> mdm_Item_construction_modification { get; set; }
        public virtual DbSet<mdm_Item_modification> mdm_Item_modification { get; set; }
        public virtual DbSet<mods_4_EPV_chk_KTD> mods_4_EPV_chk_KTD { get; set; }
        public virtual DbSet<stage_1_2_mods> stage_1_2_mods { get; set; }
        public virtual DbSet<stage_1_2_mods_constr> stage_1_2_mods_constr { get; set; }
        public virtual DbSet<stage_1_mods_KTD> stage_1_mods_KTD { get; set; }
        public virtual DbSet<TEMP_marks_mods_4_1C> TEMP_marks_mods_4_1C { get; set; }
        public virtual DbSet<TEMP_newI_IDMDM_in_tableout> TEMP_newI_IDMDM_in_tableout { get; set; }
        public virtual DbSet<TEMP_OC_ALL> TEMP_OC_ALL { get; set; }
        public virtual DbSet<Temp_PG_View_UnicEndProd> Temp_PG_View_UnicEndProd { get; set; }
        public virtual DbSet<TEMP_View_1_Rec> TEMP_View_1_Rec { get; set; }
        public virtual DbSet<TEMP_view_idSubObj4objType> TEMP_view_idSubObj4objType { get; set; }
        public virtual DbSet<TEMP_View_Product> TEMP_View_Product { get; set; }
        public virtual DbSet<TEMP_View_Row_Test> TEMP_View_Row_Test { get; set; }
        public virtual DbSet<TEMP_View_TypePrefix> TEMP_View_TypePrefix { get; set; }
        public virtual DbSet<TEMP_View_Арматура> TEMP_View_Арматура { get; set; }
        public virtual DbSet<TEMP_View_Дерево> TEMP_View_Дерево { get; set; }
        public virtual DbSet<TEMP_View_Коробки> TEMP_View_Коробки { get; set; }
        public virtual DbSet<TEMP_View_Крепёж> TEMP_View_Крепёж { get; set; }
        public virtual DbSet<TEMP_View_Полоска> TEMP_View_Полоска { get; set; }
        public virtual DbSet<TEMP_View_Уголок> TEMP_View_Уголок { get; set; }
        public virtual DbSet<TEMP_View_Утеплитель> TEMP_View_Утеплитель { get; set; }
        public virtual DbSet<TEMP_Модификаторы_все> TEMP_Модификаторы_все { get; set; }
        public virtual DbSet<TEMP_Модификаторы_используемые> TEMP_Модификаторы_используемые { get; set; }
        public virtual DbSet<TEMP_Модификаторы_с_параметрами> TEMP_Модификаторы_с_параметрами { get; set; }
        public virtual DbSet<TEMP_Модификаторы_Типов_изделий> TEMP_Модификаторы_Типов_изделий { get; set; }
        public virtual DbSet<TEMP_ОС_ОСг_АСг_ОСф> TEMP_ОС_ОСг_АСг_ОСф { get; set; }
        public virtual DbSet<TEMP_СК_МН_ЕстьВ_изделиях> TEMP_СК_МН_ЕстьВ_изделиях { get; set; }
        public virtual DbSet<TEMP_СкобаЗакладная> TEMP_СкобаЗакладная { get; set; }
        public virtual DbSet<v_actual_ver_1c> v_actual_ver_1c { get; set; }
        public virtual DbSet<v_factory_lines> v_factory_lines { get; set; }
        public virtual DbSet<v_ind_rods_1> v_ind_rods_1 { get; set; }
        public virtual DbSet<v_ind_rods_fix> v_ind_rods_fix { get; set; }
        public virtual DbSet<v_mark_versions> v_mark_versions { get; set; }
        public virtual DbSet<v_MARKS_MODS_to_delete_from_MDM> v_MARKS_MODS_to_delete_from_MDM { get; set; }
        public virtual DbSet<v_Marks_with_ends> v_Marks_with_ends { get; set; }
        public virtual DbSet<v_Marks_with_tooth> v_Marks_with_tooth { get; set; }
        public virtual DbSet<view_1C_mods> view_1C_mods { get; set; }
        public virtual DbSet<view_1C_mods_1> view_1C_mods_1 { get; set; }
        public virtual DbSet<view_3D_Zakl_Stripe> view_3D_Zakl_Stripe { get; set; }
        public virtual DbSet<View_4_ASPA_wf_Z> View_4_ASPA_wf_Z { get; set; }
        public virtual DbSet<view_addNewMark> view_addNewMark { get; set; }
        public virtual DbSet<view_ALL_alias_4_login_users> view_ALL_alias_4_login_users { get; set; }
        public virtual DbSet<view_ALL_alias_login_users_essential> view_ALL_alias_login_users_essential { get; set; }
        public virtual DbSet<view_angle> view_angle { get; set; }
        public virtual DbSet<view_arm> view_arm { get; set; }
        public virtual DbSet<view_arm_all> view_arm_all { get; set; }
        public virtual DbSet<view_arm_rope> view_arm_rope { get; set; }
        public virtual DbSet<view_ASPA_123> view_ASPA_123 { get; set; }
        public virtual DbSet<view_Building_Area_ASPA> view_Building_Area_ASPA { get; set; }
        public virtual DbSet<view_Building_Area_ASPA_rem> view_Building_Area_ASPA_rem { get; set; }
        public virtual DbSet<view_cmd_group_lisp> view_cmd_group_lisp { get; set; }
        public virtual DbSet<view_cmd_lisp_alias> view_cmd_lisp_alias { get; set; }
        public virtual DbSet<view_concreteInObjects> view_concreteInObjects { get; set; }
        public virtual DbSet<View_Count_Ropes> View_Count_Ropes { get; set; }
        public virtual DbSet<View_Count_Ropes_4MaxVer> View_Count_Ropes_4MaxVer { get; set; }
        public virtual DbSet<view_DOORS> view_DOORS { get; set; }
        public virtual DbSet<view_dry_mix> view_dry_mix { get; set; }
        public virtual DbSet<view_elementobjecttype> view_elementobjecttype { get; set; }
        public virtual DbSet<view_end_prod_consist> view_end_prod_consist { get; set; }
        public virtual DbSet<view_end_prod_consist_Mark_2ASPA> view_end_prod_consist_Mark_2ASPA { get; set; }
        public virtual DbSet<view_end_prod_consist_2ASPA> view_end_prod_consist_2ASPA { get; set; }
        public virtual DbSet<view_end_prod_Status_fromExcel> view_end_prod_Status_fromExcel { get; set; }
        public virtual DbSet<view_end_prod_ver_allMass> view_end_prod_ver_allMass { get; set; }
        public virtual DbSet<view_end_prod_ver_RawConsist_Sum> view_end_prod_ver_RawConsist_Sum { get; set; }
        public virtual DbSet<view_end_prod_ver_RawConsist_SumKg> view_end_prod_ver_RawConsist_SumKg { get; set; }
        public virtual DbSet<view_end_prod_ver_RawConsist_SumKg_2ASPA> view_end_prod_ver_RawConsist_SumKg_2ASPA { get; set; }
        public virtual DbSet<view_EndPod_TotalDim> view_EndPod_TotalDim { get; set; }
        public virtual DbSet<view_EndPod_TotalDim_2ASPA> view_EndPod_TotalDim_2ASPA { get; set; }
        public virtual DbSet<view_EndProd_Raw> view_EndProd_Raw { get; set; }
        public virtual DbSet<view_endproduct> view_endproduct { get; set; }
        public virtual DbSet<view_endproduct_cut> view_endproduct_cut { get; set; }
        public virtual DbSet<view_entity_mark_trim_ASPA> view_entity_mark_trim_ASPA { get; set; }
        public virtual DbSet<view_entity_mark_trim_ASPA_rem> view_entity_mark_trim_ASPA_rem { get; set; }
        public virtual DbSet<view_entity_mark_type_C1P> view_entity_mark_type_C1P { get; set; }
        public virtual DbSet<view_fact_lines> view_fact_lines { get; set; }
        public virtual DbSet<view_forming_type_C1P> view_forming_type_C1P { get; set; }
        public virtual DbSet<view_forming_type_C1P_rem> view_forming_type_C1P_rem { get; set; }
        public virtual DbSet<view_fstn_element> view_fstn_element { get; set; }
        public virtual DbSet<view_galvanized_iron> view_galvanized_iron { get; set; }
        public virtual DbSet<view_group_alias_4_login_users> view_group_alias_4_login_users { get; set; }
        public virtual DbSet<view_GroupMarkOkStatus> view_GroupMarkOkStatus { get; set; }
        public virtual DbSet<view_heater> view_heater { get; set; }
        public virtual DbSet<View_ID_Bracket> View_ID_Bracket { get; set; }
        public virtual DbSet<View_id_modif_Bracket> View_id_modif_Bracket { get; set; }
        public virtual DbSet<view_id_object_SEM_3layers> view_id_object_SEM_3layers { get; set; }
        public virtual DbSet<view_id_object_SEM_REN_3layers> view_id_object_SEM_REN_3layers { get; set; }
        public virtual DbSet<view_Id_outer_user_login> view_Id_outer_user_login { get; set; }
        public virtual DbSet<view_Id_PIC_user_login> view_Id_PIC_user_login { get; set; }
        public virtual DbSet<View_ID_RDS> View_ID_RDS { get; set; }
        public virtual DbSet<view_idObType4MarkPref> view_idObType4MarkPref { get; set; }
        public virtual DbSet<view_item_const_forming_C1P> view_item_const_forming_C1P { get; set; }
        public virtual DbSet<view_Item_construction_C1P> view_Item_construction_C1P { get; set; }
        public virtual DbSet<view_Item_construction_modification_list_C1P> view_Item_construction_modification_list_C1P { get; set; }
        public virtual DbSet<view_Item_modification_list_C1P> view_Item_modification_list_C1P { get; set; }
        public virtual DbSet<view_ItemConstModif> view_ItemConstModif { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer> View_ItmConsID_by_idEndProdVer { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer2> View_ItmConsID_by_idEndProdVer2 { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer3> View_ItmConsID_by_idEndProdVer3 { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer4> View_ItmConsID_by_idEndProdVer4 { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer5> View_ItmConsID_by_idEndProdVer5 { get; set; }
        public virtual DbSet<View_ItmConsID_by_idEndProdVer6> View_ItmConsID_by_idEndProdVer6 { get; set; }
        public virtual DbSet<view_ItmConsId_by_IdNPCon> view_ItmConsId_by_IdNPCon { get; set; }
        public virtual DbSet<view_job_files> view_job_files { get; set; }
        public virtual DbSet<view_job_files_4_Load> view_job_files_4_Load { get; set; }
        public virtual DbSet<view_job_files_UUID_4_Load> view_job_files_UUID_4_Load { get; set; }
        public virtual DbSet<view_ktd_heater_3d> view_ktd_heater_3d { get; set; }
        public virtual DbSet<view_lines> view_lines { get; set; }
        public virtual DbSet<view_managed_outer_alias> view_managed_outer_alias { get; set; }
        public virtual DbSet<view_managed_outer_command> view_managed_outer_command { get; set; }
        public virtual DbSet<view_managed_outer_group> view_managed_outer_group { get; set; }
        public virtual DbSet<view_managed_PIC_command> view_managed_PIC_command { get; set; }
        public virtual DbSet<view_managed_PIC_group> view_managed_PIC_group { get; set; }
        public virtual DbSet<view_mark_code_type_C1P> view_mark_code_type_C1P { get; set; }
        public virtual DbSet<view_mark4OSOSf> view_mark4OSOSf { get; set; }
        public virtual DbSet<view_markName_Npcon_Mdm> view_markName_Npcon_Mdm { get; set; }
        public virtual DbSet<view_markUnicNameT_cancel> view_markUnicNameT_cancel { get; set; }
        public virtual DbSet<view_markUnicNameT_status> view_markUnicNameT_status { get; set; }
        public virtual DbSet<view_Max_ID_EndPodVer_4_ID_EndProd> view_Max_ID_EndPodVer_4_ID_EndProd { get; set; }
        public virtual DbSet<view_mbox> view_mbox { get; set; }
        public virtual DbSet<view_MDM_NpCon_mark_C1P> view_MDM_NpCon_mark_C1P { get; set; }
        public virtual DbSet<view_modif_and_param_4add> view_modif_and_param_4add { get; set; }
        public virtual DbSet<view_modificators> view_modificators { get; set; }
        public virtual DbSet<view_modificators_oldver> view_modificators_oldver { get; set; }
        public virtual DbSet<view_modifType_4objType> view_modifType_4objType { get; set; }
        public virtual DbSet<view_MODS_TO_MDM> view_MODS_TO_MDM { get; set; }
        public virtual DbSet<view_msaspa_taskmanager_items_ALL> view_msaspa_taskmanager_items_ALL { get; set; }
        public virtual DbSet<view_msaspa_taskmanager_items_work> view_msaspa_taskmanager_items_work { get; set; }
        public virtual DbSet<view_node> view_node { get; set; }
        public virtual DbSet<View_npcon_changed_idProd> View_npcon_changed_idProd { get; set; }
        public virtual DbSet<View_npcon_changed_maxIdEndProdVer> View_npcon_changed_maxIdEndProdVer { get; set; }
        public virtual DbSet<View_npcon_changed_product> View_npcon_changed_product { get; set; }
        public virtual DbSet<View_npcon_changed_product_22_06_2020> View_npcon_changed_product_22_06_2020 { get; set; }
        public virtual DbSet<View_npcon_changed_product_alter> View_npcon_changed_product_alter { get; set; }
        public virtual DbSet<View_npcon_changed_product_chk_KTD> View_npcon_changed_product_chk_KTD { get; set; }
        public virtual DbSet<View_npcon_changed_product_reserve_del> View_npcon_changed_product_reserve_del { get; set; }
        public virtual DbSet<View_npcon_changed_product1> View_npcon_changed_product1 { get; set; }
        public virtual DbSet<View_npcon_changed_product3> View_npcon_changed_product3 { get; set; }
        public virtual DbSet<View_npcon_changed_product4> View_npcon_changed_product4 { get; set; }
        public virtual DbSet<view_NPCon_mods> view_NPCon_mods { get; set; }
        public virtual DbSet<view_NPCon_mods_1> view_NPCon_mods_1 { get; set; }
        public virtual DbSet<view_objalbumorgost> view_objalbumorgost { get; set; }
        public virtual DbSet<view_objconsist> view_objconsist { get; set; }
        public virtual DbSet<view_OS_Ropes> view_OS_Ropes { get; set; }
        public virtual DbSet<view_permtype> view_permtype { get; set; }
        public virtual DbSet<view_person_alias_4_login_users> view_person_alias_4_login_users { get; set; }
        public virtual DbSet<view_product> view_product { get; set; }
        public virtual DbSet<view_product_dim_1> view_product_dim_1 { get; set; }
        public virtual DbSet<view_product_dim_1_Group> view_product_dim_1_Group { get; set; }
        public virtual DbSet<view_Product_Mark_C1P> view_Product_Mark_C1P { get; set; }
        public virtual DbSet<view_product_modification> view_product_modification { get; set; }
        public virtual DbSet<view_Raw_Units> view_Raw_Units { get; set; }
        public virtual DbSet<view_RDS> view_RDS { get; set; }
        public virtual DbSet<view_Shelf_mark_MaxID> view_Shelf_mark_MaxID { get; set; }
        public virtual DbSet<view_spiral_hose> view_spiral_hose { get; set; }
        public virtual DbSet<view_strip> view_strip { get; set; }
        public virtual DbSet<view_svod_ASPA> view_svod_ASPA { get; set; }
        public virtual DbSet<view_TEMP_PR_last_UUID> view_TEMP_PR_last_UUID { get; set; }
        public virtual DbSet<View_TEMP1C> View_TEMP1C { get; set; }
        public virtual DbSet<view_test_mark07> view_test_mark07 { get; set; }
        public virtual DbSet<view_tube> view_tube { get; set; }
        public virtual DbSet<view_user_alias_lisp> view_user_alias_lisp { get; set; }
        public virtual DbSet<view_user_domain> view_user_domain { get; set; }
        public virtual DbSet<view_user_domain_roles> view_user_domain_roles { get; set; }
        public virtual DbSet<view_WINDOWS> view_WINDOWS { get; set; }
        public virtual DbSet<view_wood> view_wood { get; set; }
        public virtual DbSet<view_WrkFile_MarkMails> view_WrkFile_MarkMails { get; set; }
        public virtual DbSet<view_WrkFile_MarkPlans> view_WrkFile_MarkPlans { get; set; }
        public virtual DbSet<view_WrkFile_MarkProducts> view_WrkFile_MarkProducts { get; set; }
        public virtual DbSet<view_ПравильныеПроёмыМарок> view_ПравильныеПроёмыМарок { get; set; }
        public virtual DbSet<view_РазницаПараметров2> view_РазницаПараметров2 { get; set; }
        public virtual DbSet<View_РазницаПараметров3> View_РазницаПараметров3 { get; set; }
        public virtual DbSet<View_РазницаПараметров4> View_РазницаПараметров4 { get; set; }
        public virtual DbSet<View_РазницаПараметров5> View_РазницаПараметров5 { get; set; }
        public virtual DbSet<View_СравнениеПараметров_1С_МДМ_NPCon> View_СравнениеПараметров_1С_МДМ_NPCon { get; set; }
        public virtual DbSet<view1> view1 { get; set; }
        public virtual DbSet<viewNodesContent> viewNodesContent { get; set; }
        public virtual DbSet<ZAKL_ANKERA_all_comp> ZAKL_ANKERA_all_comp { get; set; }
        public virtual DbSet<viewIfcModificators> viewIfcModificators { get; set; }
        public virtual DbSet<viewProjectData> viewProjectData { get; set; }
        public virtual DbSet<view_UserActivityStat> view_UserActivityStat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<album>()
                .HasMany(e => e.tblNodeDepth)
                .WithRequired(e => e.album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<album>()
                .HasMany(e => e.tblNodesContent)
                .WithRequired(e => e.album)
                .HasForeignKey(e => e.AlbumId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<album>()
                .HasMany(e => e.listalb)
                .WithRequired(e => e.album)
                .HasForeignKey(e => e.id_album_list);

            modelBuilder.Entity<allLayer>()
                .HasMany(e => e.objecttype)
                .WithMany(e => e.allLayer)
                .Map(m => m.ToTable("productLayer").MapLeftKey("ID_layer4Product").MapRightKey("ID_obj_type"));

            modelBuilder.Entity<angle>()
                .Property(e => e.thickness)
                .HasPrecision(4, 1);

            modelBuilder.Entity<arm_type>()
                .HasMany(e => e.Lines)
                .WithRequired(e => e.arm_type)
                .HasForeignKey(e => e.id_arm_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<classType>()
                .HasMany(e => e.work_file)
                .WithOptional(e => e.classType)
                .HasForeignKey(e => e._class);

            modelBuilder.Entity<cmd_groups>()
                .HasMany(e => e.cmd_lisp)
                .WithMany(e => e.cmd_groups)
                .Map(m => m.ToTable("cmd_group_lisp").MapLeftKey("id_group").MapRightKey("id_lisp"));

            modelBuilder.Entity<cmd_groups>()
                .HasMany(e => e.cmd_userlogins)
                .WithMany(e => e.cmd_groups)
                .Map(m => m.ToTable("cmd_userroles").MapLeftKey("id_group").MapRightKey("id_userlogin"));

            modelBuilder.Entity<cmd_lisp>()
                .HasMany(e => e.cmd_alias)
                .WithRequired(e => e.cmd_lisp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cmd_lisp>()
                .HasMany(e => e.cmd_user_lisp)
                .WithRequired(e => e.cmd_lisp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cmd_userdomains>()
                .HasMany(e => e.cmd_userlogins)
                .WithRequired(e => e.cmd_userdomains)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cmd_userlogins>()
                .HasMany(e => e.cmd_user_lisp)
                .WithRequired(e => e.cmd_userlogins)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cmd_users>()
                .HasMany(e => e.cmd_userlogins)
                .WithRequired(e => e.cmd_users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<concrType>()
                .HasMany(e => e.Lines)
                .WithRequired(e => e.concrType)
                .HasForeignKey(e => e.id_type_of_concr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<end_prod_ver_consist>()
                .Property(e => e.object_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<end_prod_ver_RawConsist>()
                .Property(e => e.raw_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<end_product_version>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<end_product_version>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<end_product_version>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<factory>()
                .HasMany(e => e.factory_lines)
                .WithRequired(e => e.factory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<formingEquip>()
                .HasMany(e => e.Lines)
                .WithRequired(e => e.formingEquip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fstn_name>()
                .HasMany(e => e.fstn_element)
                .WithRequired(e => e.fstn_name)
                .HasForeignKey(e => e.id_name_felem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<galvanized_iron>()
                .Property(e => e.thickness)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Lines>()
                .Property(e => e.UID_1c)
                .IsFixedLength();

            modelBuilder.Entity<Lines>()
                .Property(e => e.row_ver)
                .IsFixedLength();

            modelBuilder.Entity<Lines>()
                .HasMany(e => e.factory_lines)
                .WithRequired(e => e.Lines)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lisp_interface>()
                .HasMany(e => e.user)
                .WithMany(e => e.lisp_interface)
                .Map(m => m.ToTable("user_interface").MapLeftKey("InterfaceID").MapRightKey("UserID"));

            modelBuilder.Entity<mark_type>()
                .HasMany(e => e.objectmark)
                .WithRequired(e => e.mark_type)
                .HasForeignKey(e => e.id_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mark_type>()
                .HasMany(e => e.objecttype)
                .WithOptional(e => e.mark_type)
                .HasForeignKey(e => e.id_type4mark);

            modelBuilder.Entity<mdm_Item_modification_t>()
                .HasMany(e => e.modification_parameter)
                .WithRequired(e => e.mdm_Item_modification_t)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mdm_Item_modification_t>()
                .HasMany(e => e.modificationType4object_type)
                .WithRequired(e => e.mdm_Item_modification_t)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mdm_object_plain>()
                .HasMany(e => e.work_file)
                .WithMany(e => e.mdm_object_plain)
                .Map(m => m.ToTable("work_file_floors").MapLeftKey("id_floor").MapRightKey("id_work_file"));

            modelBuilder.Entity<modification_parameter>()
                .HasMany(e => e.mod_param_value_pool)
                .WithRequired(e => e.modification_parameter)
                .HasForeignKey(e => new { e.id_modif, e.id_param })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<modification_parameter>()
                .HasMany(e => e.product_modification)
                .WithOptional(e => e.modification_parameter)
                .HasForeignKey(e => new { e.id_modif, e.id_param });

            modelBuilder.Entity<modificationType4object_type>()
                .HasMany(e => e.product_modification)
                .WithRequired(e => e.modificationType4object_type)
                .HasForeignKey(e => new { e.id_objecttype, e.id_modif })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<normdoc>()
                .HasMany(e => e.objectmark)
                .WithOptional(e => e.normdoc)
                .HasForeignKey(e => e.id_normdoc_mark);

            modelBuilder.Entity<normdoc>()
                .HasMany(e => e.p_object)
                .WithOptional(e => e.normdoc)
                .HasForeignKey(e => e.id_normdoc_pobj);

            modelBuilder.Entity<objectconsist>()
                .Property(e => e.blanklen)
                .HasPrecision(18, 4);

            modelBuilder.Entity<objectconsist>()
                .Property(e => e.row_ver)
                .IsFixedLength();

            modelBuilder.Entity<objectmark>()
                .HasMany(e => e.objectconsist)
                .WithOptional(e => e.objectmark)
                .HasForeignKey(e => e.id_mark4subelem);

            modelBuilder.Entity<Objects>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<Objects>()
                .HasMany(e => e.Objects1)
                .WithOptional(e => e.Objects2)
                .HasForeignKey(e => e.Object_id_parent);

            modelBuilder.Entity<Objects>()
                .HasMany(e => e.projects)
                .WithOptional(e => e.Objects)
                .HasForeignKey(e => e.ProjectId);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.modificationType4object_type)
                .WithRequired(e => e.objecttype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.objectprefix)
                .WithRequired(e => e.objecttype)
                .HasForeignKey(e => e.id_objecttype_pref)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.permission4type)
                .WithRequired(e => e.objecttype)
                .HasForeignKey(e => e.idmaintype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.permission4type1)
                .WithRequired(e => e.objecttype1)
                .HasForeignKey(e => e.idpermtype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.p_object)
                .WithRequired(e => e.objecttype)
                .HasForeignKey(e => e.id_objecttype_pobj)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_concr_binder>()
                .HasMany(e => e.p_concrete)
                .WithRequired(e => e.p_concr_binder)
                .HasForeignKey(e => e.id_binder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_concr_class>()
                .Property(e => e.c_val)
                .HasPrecision(10, 2);

            modelBuilder.Entity<p_concr_class>()
                .HasMany(e => e.p_concrete)
                .WithRequired(e => e.p_concr_class)
                .HasForeignKey(e => e.id_class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_concr_comp>()
                .HasMany(e => e.p_concrete)
                .WithRequired(e => e.p_concr_comp)
                .HasForeignKey(e => e.id_composition)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_concr_frost>()
                .HasMany(e => e.p_concrete)
                .WithRequired(e => e.p_concr_frost)
                .HasForeignKey(e => e.id_frost)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_concr_waterres>()
                .HasMany(e => e.p_concrete)
                .WithRequired(e => e.p_concr_waterres)
                .HasForeignKey(e => e.id_waterres)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_object>()
                .Property(e => e.row_ver)
                .IsFixedLength();

            modelBuilder.Entity<p_object>()
                .HasMany(e => e.objectconsist)
                .WithRequired(e => e.p_object)
                .HasForeignKey(e => e.id_object_cons)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_object>()
                .HasMany(e => e.objectconsist1)
                .WithRequired(e => e.p_object1)
                .HasForeignKey(e => e.id_subobject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_object>()
                .HasOptional(e => e.product)
                .WithRequired(e => e.p_object)
                .WillCascadeOnDelete();

            modelBuilder.Entity<p_object>()
                .HasOptional(e => e.raw)
                .WithRequired(e => e.p_object)
                .WillCascadeOnDelete();

            modelBuilder.Entity<p_PEfilm>()
                .Property(e => e.thick_PEfilm)
                .HasPrecision(5, 3);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.end_prod_ver_consist)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.object_count_unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.objectconsist)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.len_units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.objecttype)
                .WithOptional(e => e.p_units)
                .HasForeignKey(e => e.tbl_unit);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.p_hdpe)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.diam_hdpe_unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.p_object)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.unitsguid_pobj)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.p_PEfilm)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.thick_PEfilm_unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.parameter)
                .WithOptional(e => e.p_units)
                .HasForeignKey(e => e.param_units);

            modelBuilder.Entity<p_units>()
                .HasMany(e => e.raw)
                .WithRequired(e => e.p_units)
                .HasForeignKey(e => e.weight_units)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<permission4type>()
                .Property(e => e.permtype_len_min)
                .HasPrecision(18, 4);

            modelBuilder.Entity<permission4type>()
                .Property(e => e.permtype_len_max)
                .HasPrecision(18, 4);

            modelBuilder.Entity<prod_work_file>()
                .HasMany(e => e.end_product_version)
                .WithOptional(e => e.prod_work_file)
                .HasForeignKey(e => e.id_prod_workfile);

            modelBuilder.Entity<product>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product>()
                .Property(e => e.volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product>()
                .Property(e => e.product_area_1С)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product>()
                .Property(e => e.Weight_1С)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product>()
                .HasMany(e => e.end_product_version)
                .WithRequired(e => e.product)
                .HasForeignKey(e => e.id_end_prod);

            modelBuilder.Entity<product>()
                .HasMany(e => e.prod_work_file)
                .WithRequired(e => e.product)
                .HasForeignKey(e => e.id_obj_prod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.product_modification)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product_modification>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<raw>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.angle)
                .WithRequired(e => e.raw)
                .WillCascadeOnDelete();

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.arm)
                .WithRequired(e => e.raw)
                .WillCascadeOnDelete();

            modelBuilder.Entity<raw>()
                .HasMany(e => e.end_prod_ver_RawConsist)
                .WithRequired(e => e.raw)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.fstn_element)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.galvanized_iron)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.m_box)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.p_concrete)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.p_hdpe)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.p_PEfilm)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.strip)
                .WithRequired(e => e.raw)
                .WillCascadeOnDelete();

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.spiral_hose)
                .WithRequired(e => e.raw)
                .WillCascadeOnDelete();

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.tube)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<raw>()
                .HasOptional(e => e.wood)
                .WithRequired(e => e.raw);

            modelBuilder.Entity<sql_data_type>()
                .HasMany(e => e.parameter)
                .WithRequired(e => e.sql_data_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<steelClasses>()
                .HasMany(e => e.Lines)
                .WithRequired(e => e.steelClasses)
                .HasForeignKey(e => e.id_class_of_steel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tube>()
                .Property(e => e.diam)
                .HasPrecision(6, 1);

            modelBuilder.Entity<tube>()
                .Property(e => e.thickness)
                .HasPrecision(18, 4);

            modelBuilder.Entity<version_status>()
                .HasMany(e => e.end_product_version)
                .WithRequired(e => e.version_status)
                .HasForeignKey(e => e.ver_status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<work_file>()
                .HasMany(e => e.prod_work_file)
                .WithRequired(e => e.work_file)
                .HasForeignKey(e => e.id_workfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<work_file>()
                .HasMany(e => e.KZI)
                .WithOptional(e => e.work_file)
                .HasForeignKey(e => e.WorkFileId);

            modelBuilder.Entity<work_file>()
                .HasMany(e => e.work_file_mark_type)
                .WithRequired(e => e.work_file)
                .HasForeignKey(e => e.id_work_file)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<work_file>()
                .HasMany(e => e.work_file1)
                .WithOptional(e => e.work_file2)
                .HasForeignKey(e => e.Links);

            modelBuilder.Entity<work_file>()
                .HasMany(e => e.zone)
                .WithMany(e => e.work_file)
                .Map(m => m.ToTable("work_file_zone").MapLeftKey("Id_wok_file").MapRightKey("Id_flor_type"));

            modelBuilder.Entity<wpf_control>()
                .HasMany(e => e.wpf_property)
                .WithMany(e => e.wpf_control)
                .Map(m => m.ToTable("wpf_control_property").MapLeftKey("id_control").MapRightKey("id_property"));

            modelBuilder.Entity<wrk_file_type>()
                .HasMany(e => e.prod_work_file)
                .WithRequired(e => e.wrk_file_type)
                .HasForeignKey(e => e.work_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assembly>()
                .HasMany(e => e.Assembly_structure)
                .WithRequired(e => e.Assembly)
                .HasForeignKey(e => e.UID_Assembly)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assembly>()
                .HasMany(e => e.Assembly_structure1)
                .WithOptional(e => e.Assembly1)
                .HasForeignKey(e => e.UID_Assembly_Part);

            modelBuilder.Entity<Assembly>()
                .HasMany(e => e.KZI)
                .WithRequired(e => e.Assembly)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<floors>()
                .HasMany(e => e.project_specific)
                .WithRequired(e => e.floors)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Geometry>()
                .HasMany(e => e.nomenclature_all)
                .WithRequired(e => e.Geometry)
                .HasForeignKey(e => e.UID_Geometry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Geometry>()
                .HasMany(e => e.nomenclature_current)
                .WithRequired(e => e.Geometry)
                .HasForeignKey(e => e.UID_Geometry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KZI_Name>()
                .HasMany(e => e.KZI)
                .WithRequired(e => e.KZI_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KZI_Name>()
                .HasMany(e => e.nomenclature)
                .WithRequired(e => e.KZI_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nomenclature>()
                .HasMany(e => e.project_specific)
                .WithRequired(e => e.nomenclature)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parameters>()
                .HasMany(e => e.nomenclature_current)
                .WithOptional(e => e.Parameters)
                .HasForeignKey(e => e.UID_Parameters);

            modelBuilder.Entity<Parameters>()
                .HasMany(e => e.nomenclature_all)
                .WithRequired(e => e.Parameters)
                .HasForeignKey(e => e.UID_Parameters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<projects>()
                .HasMany(e => e.sections)
                .WithRequired(e => e.projects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sections>()
                .HasMany(e => e.floors)
                .WithRequired(e => e.sections)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<coloristics>()
                .Property(e => e.resp_person)
                .IsFixedLength();

            modelBuilder.Entity<addmods_from_C1>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<addmods_from_C1>()
                .Property(e => e.Item_modification_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<aspa_entity>()
                .Property(e => e.uuid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<base_ch_npcon>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<base_changes_delete>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<from_view_product_dim_1_Tbl>()
                .Property(e => e.вес)
                .HasPrecision(18, 4);

            modelBuilder.Entity<from_view_product_dim_1_Tbl>()
                .Property(e => e.объём)
                .HasPrecision(18, 4);

            modelBuilder.Entity<from_view_product_dim_1_Tbl>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Heater_correct>()
                .Property(e => e.dwg_volume)
                .HasPrecision(19, 6);

            modelBuilder.Entity<IDMDM_ModId_from_1c>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<IDMDM_ModId_from_1c>()
                .Property(e => e.Item_modification_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Weight)
                .HasPrecision(5, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Volume)
                .HasPrecision(8, 3);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Area)
                .HasPrecision(10, 3);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Length)
                .HasPrecision(4, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Width)
                .HasPrecision(4, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Height)
                .HasPrecision(4, 0);

            modelBuilder.Entity<lastModsMarksfrom1C>()
                .Property(e => e.Item_modification_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<loaded_Job_Files>()
                .Property(e => e.f_path)
                .IsUnicode(false);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Weight)
                .HasPrecision(5, 0);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Volume)
                .HasPrecision(8, 3);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Area)
                .HasPrecision(10, 3);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Length)
                .HasPrecision(4, 0);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Width)
                .HasPrecision(4, 0);

            modelBuilder.Entity<loaded_Marks_from_1C>()
                .Property(e => e.Height)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Marks_and_modifications_from_EXCEL>()
                .Property(e => e.Item_group_MDM)
                .IsFixedLength();

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Weight)
                .HasPrecision(5, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Volume)
                .HasPrecision(8, 3);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Area)
                .HasPrecision(10, 3);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Length)
                .HasPrecision(4, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Width)
                .HasPrecision(4, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Height)
                .HasPrecision(4, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.Item_modification_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<mods_loaded_from_1c>()
                .Property(e => e.ModificationValue)
                .HasPrecision(15, 3);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Weight)
                .HasPrecision(5, 0);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Volume)
                .HasPrecision(8, 3);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Area)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Length)
                .HasPrecision(4, 0);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Width)
                .HasPrecision(4, 0);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Height)
                .HasPrecision(4, 0);

            modelBuilder.Entity<ModsMarksfrom1C>()
                .Property(e => e.Item_modification_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<params_loaded_from_1c>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<params_loaded_from_1c>()
                .Property(e => e.Length)
                .HasPrecision(10, 2);

            modelBuilder.Entity<params_loaded_from_1c>()
                .Property(e => e.Width)
                .HasPrecision(10, 2);

            modelBuilder.Entity<params_loaded_from_1c>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<params_loaded_from_1c>()
                .Property(e => e.Square_of_ObjGeom)
                .HasPrecision(10, 2);

            modelBuilder.Entity<product_Dev>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product_Dev>()
                .Property(e => e.volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product_Dev>()
                .Property(e => e.product_area_1С)
                .HasPrecision(18, 4);

            modelBuilder.Entity<product_Dev>()
                .Property(e => e.Weight_1С)
                .HasPrecision(18, 4);

            modelBuilder.Entity<to_SerOfMarks_t>()
                .Property(e => e.id_mdm)
                .HasPrecision(10, 0);

            modelBuilder.Entity<a_view_Shelf_mark_MaxID>()
                .Property(e => e.blk_handle)
                .IsUnicode(false);

            modelBuilder.Entity<a_view_Shelf_mark_MaxID>()
                .Property(e => e.UUID_file)
                .IsUnicode(false);

            modelBuilder.Entity<a_view_Shelf_mark_MaxID>()
                .Property(e => e.mark_from_dwg)
                .IsUnicode(false);

            modelBuilder.Entity<ERRORS_IN_APERTURES>()
                .Property(e => e.err_in_parsing)
                .IsUnicode(false);

            modelBuilder.Entity<mdm_Item_construction>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<mdm_Item_construction_modification>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<mdm_Item_modification>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.ОбъемВнутреннегоСлоя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.ОбъемНаружногоСлоя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_marks_mods_4_1C>()
                .Property(e => e.ОбъемУтеплителя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_newI_IDMDM_in_tableout>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TEMP_OC_ALL>()
                .Property(e => e.длина_суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_OC_ALL>()
                .Property(e => e.вес_за_1_ед_изм__суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Product>()
                .Property(e => e.длина_суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Product>()
                .Property(e => e.вес_за_1_ед_изм__суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Product>()
                .Property(e => e.thickness_уголка)
                .HasPrecision(4, 1);

            modelBuilder.Entity<TEMP_View_Row_Test>()
                .Property(e => e.Вес_за_1м_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Арматура>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Дерево>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Коробки>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Крепёж>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Полоска>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_View_Уголок>()
                .Property(e => e.толщина)
                .HasPrecision(4, 1);

            modelBuilder.Entity<TEMP_View_Уголок>()
                .Property(e => e.вес_за_1_ед_изм_изделия)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_ОС_ОСг_АСг_ОСф>()
                .Property(e => e.длина_суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_ОС_ОСг_АСг_ОСф>()
                .Property(e => e.вес_за_1_ед_изм__суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_СК_МН_ЕстьВ_изделиях>()
                .Property(e => e.длина_суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_СК_МН_ЕстьВ_изделиях>()
                .Property(e => e.вес_за_1_ед_изм__суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_СК_МН_ЕстьВ_изделиях>()
                .Property(e => e.thickness_уголка)
                .HasPrecision(4, 1);

            modelBuilder.Entity<TEMP_СкобаЗакладная>()
                .Property(e => e.длина_суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_СкобаЗакладная>()
                .Property(e => e.вес_за_1_ед_изм__суб_об_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TEMP_СкобаЗакладная>()
                .Property(e => e.thickness_уголка)
                .HasPrecision(4, 1);

            modelBuilder.Entity<v_actual_ver_1c>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_actual_ver_1c>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_actual_ver_1c>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_factory_lines>()
                .Property(e => e.CAD_Данные)
                .IsUnicode(false);

            modelBuilder.Entity<v_ind_rods_1>()
                .Property(e => e.Длина_составляющего)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_ind_rods_fix>()
                .Property(e => e.Длина_составляющего)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_mark_versions>()
                .Property(e => e.Кол_во_составляющих)
                .HasPrecision(18, 4);

            modelBuilder.Entity<v_mark_versions>()
                .Property(e => e.Представление_состава)
                .IsUnicode(false);

            modelBuilder.Entity<view_1C_mods>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<view_1C_mods>()
                .Property(e => e.Item_modification_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<view_1C_mods_1>()
                .Property(e => e.id_npcon)
                .HasPrecision(10, 0);

            modelBuilder.Entity<view_1C_mods_1>()
                .Property(e => e.ID_MDM)
                .HasPrecision(10, 0);

            modelBuilder.Entity<view_1C_mods_1>()
                .Property(e => e.Item_modification_ID)
                .HasPrecision(10, 0);

            modelBuilder.Entity<view_3D_Zakl_Stripe>()
                .Property(e => e.blanklen)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_ALL_alias_4_login_users>()
                .Property(e => e.TypePermission)
                .IsUnicode(false);

            modelBuilder.Entity<view_ALL_alias_login_users_essential>()
                .Property(e => e.TypePermission)
                .IsUnicode(false);

            modelBuilder.Entity<view_angle>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_angle>()
                .Property(e => e.thickness)
                .HasPrecision(4, 1);

            modelBuilder.Entity<view_arm>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_arm_all>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_concreteInObjects>()
                .Property(e => e.object_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_Count_Ropes>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_Count_Ropes_4MaxVer>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_DOORS>()
                .Property(e => e.Тип_проема)
                .IsUnicode(false);

            modelBuilder.Entity<view_dry_mix>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_consist>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_consist>()
                .Property(e => e.object_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_consist_Mark_2ASPA>()
                .Property(e => e.object_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_consist_2ASPA>()
                .Property(e => e.object_count)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_ver_allMass>()
                .Property(e => e.verMass)
                .HasPrecision(38, 6);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_Sum>()
                .Property(e => e.raw_countSum)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg>()
                .Property(e => e.raw_countSum)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg>()
                .Property(e => e.AllMass)
                .HasPrecision(38, 6);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg_2ASPA>()
                .Property(e => e.raw_countSum)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg_2ASPA>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_end_prod_ver_RawConsist_SumKg_2ASPA>()
                .Property(e => e.расход)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_EndPod_TotalDim>()
                .Property(e => e.вес)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_EndPod_TotalDim>()
                .Property(e => e.объём)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_EndPod_TotalDim_2ASPA>()
                .Property(e => e.вес_изделия_т_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_EndPod_TotalDim_2ASPA>()
                .Property(e => e.вес_металла_кг_)
                .HasPrecision(38, 6);

            modelBuilder.Entity<view_EndPod_TotalDim_2ASPA>()
                .Property(e => e.объём)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_EndProd_Raw>()
                .Property(e => e.количество_материала)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_endproduct>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct>()
                .Property(e => e.volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct_cut>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct_cut>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_endproduct_cut>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_entity_mark_type_C1P>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<view_fstn_element>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_galvanized_iron>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_galvanized_iron>()
                .Property(e => e.thickness)
                .HasPrecision(6, 2);

            modelBuilder.Entity<view_heater>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_heater>()
                .Property(e => e.volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_Item_construction_C1P>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer2>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer2>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer2>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer2>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer3>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer3>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer3>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer3>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer4>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer4>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer4>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer4>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.ConcrVolBtn_IN_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.ConcrVolBtn_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.ConcrVolBtn_FrontSide_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer5>()
                .Property(e => e.ConcrVolBtn_UpperEndFace_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.ConcrVolBtn_IN_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.ConcrVolBtn_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.ConcrVolBtn_FrontSide_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_ItmConsID_by_idEndProdVer6>()
                .Property(e => e.ConcrVolBtn_UpperEndFace_vol)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_lines>()
                .Property(e => e.UID_1c)
                .IsFixedLength();

            modelBuilder.Entity<view_mark4OSOSf>()
                .Property(e => e.blanklen)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_mbox>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Консоль)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Выступ_Зуб_)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Утеплитель)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Петлевой_выпуск)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Скоба)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Торец)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Автор)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators>()
                .Property(e => e.Проем)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Консоль)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Выступ_Зуб_)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Утеплитель)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Петлевой_выпуск)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Торец)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Автор)
                .IsUnicode(false);

            modelBuilder.Entity<view_modificators_oldver>()
                .Property(e => e.Проем)
                .IsUnicode(false);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.ОбъемВнутреннегоСлоя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.ОбъемФасадЧастьОсн)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.ОбъемФасадЧастьБок)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product>()
                .Property(e => e.ОбъемТорецВерх_зуб)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_22_06_2020>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_22_06_2020>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_22_06_2020>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product_22_06_2020>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product_alter>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_alter>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_alter>()
                .Property(e => e.Вес)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_alter>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.ОбъемВнутреннегоСлоя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.ОбъемФасадЧастьОсн)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.ОбъемФасадЧастьБок)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_chk_KTD>()
                .Property(e => e.ОбъемТорецВерх_зуб)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.ОбъемВнутреннегоСлоя)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.ОбъемФасадЧастьОсн)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.ОбъемФасадЧастьБок)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product_reserve_del>()
                .Property(e => e.ОбъемТорецВерх_зуб)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product1>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product1>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product1>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product1>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product3>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product3>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product3>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product3>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.Площадь)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.Объем)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.Вес)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.КоличествоКанатов)
                .HasPrecision(38, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.ОбъемВнутреннегоСлоя_спец)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.ОбъемФасадЧастьОсн)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.ОбъемФасадЧастьБок)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_npcon_changed_product4>()
                .Property(e => e.ОбъемТорецВерх_зуб_)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_objconsist>()
                .Property(e => e.blanklen)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_permtype>()
                .Property(e => e.permtype_len_min)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_permtype>()
                .Property(e => e.permtype_len_max)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product>()
                .Property(e => e.prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product>()
                .Property(e => e.volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1>()
                .Property(e => e.вес)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1>()
                .Property(e => e.объём)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1_Group>()
                .Property(e => e.вес)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1_Group>()
                .Property(e => e.объём)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_dim_1_Group>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_product_modification>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<view_Shelf_mark_MaxID>()
                .Property(e => e.blk_handle)
                .IsUnicode(false);

            modelBuilder.Entity<view_Shelf_mark_MaxID>()
                .Property(e => e.UUID_file)
                .IsUnicode(false);

            modelBuilder.Entity<view_Shelf_mark_MaxID>()
                .Property(e => e.mark_from_dwg)
                .IsUnicode(false);

            modelBuilder.Entity<view_spiral_hose>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_strip>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_TEMP_PR_last_UUID>()
                .Property(e => e.UUID_file)
                .IsUnicode(false);

            modelBuilder.Entity<View_TEMP1C>()
                .Property(e => e.end_prod_volume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_TEMP1C>()
                .Property(e => e.end_prod_weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_TEMP1C>()
                .Property(e => e.end_prod_area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_TEMP1C>()
                .Property(e => e.count_ropes)
                .HasPrecision(38, 4);

            modelBuilder.Entity<view_tube>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_tube>()
                .Property(e => e.thickness)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_WINDOWS>()
                .Property(e => e.Тип_проема)
                .IsUnicode(false);

            modelBuilder.Entity<view_wood>()
                .Property(e => e.weight)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.NPConWeight)
                .HasPrecision(23, 4);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Volume)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.NPConVolume)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Thickness)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.NPCon_Area)
                .HasPrecision(18, 4);

            modelBuilder.Entity<view_РазницаПараметров2>()
                .Property(e => e.overall_Thickness)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Вес_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Вес_NpCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Объём_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Объём_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Длина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Высота_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Толщина_1С)
                .IsFixedLength();

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Площадь_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Площадь_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров3>()
                .Property(e => e.Габ_толщина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Вес_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Вес_NpCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Объём_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Объём_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Длина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Высота_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Толщина_1С)
                .IsFixedLength();

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Площадь_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Площадь_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров4>()
                .Property(e => e.Габ_толщина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_РазницаПараметров5>()
                .Property(e => e.Вес_NpCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров5>()
                .Property(e => e.Объём_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_РазницаПараметров5>()
                .Property(e => e.Площадь_NPCon)
                .HasPrecision(18, 4);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Вес_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Вес_NpCon)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Вес_МДМ)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Объём_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Объём_NPCon)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Объём_МДМ)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Длина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Высота_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Толщина_1С)
                .IsFixedLength();

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Площадь_1С)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Площадь_NPCon)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Площадь_МДМ)
                .IsUnicode(false);

            modelBuilder.Entity<View_СравнениеПараметров_1С_МДМ_NPCon>()
                .Property(e => e.Габ_толщина_1С)
                .IsUnicode(false);

            modelBuilder.Entity<ZAKL_ANKERA_all_comp>()
                .Property(e => e.Измеритель_составляющей)
                .HasPrecision(18, 4);
        }
    }
}
