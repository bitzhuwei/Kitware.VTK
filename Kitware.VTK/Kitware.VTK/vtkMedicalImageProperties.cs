using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMedicalImageProperties : vtkObject
	{
		public enum OrientationType
		{
			AXIAL,
			CORONAL,
			SAGITTAL
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageProperties";

		public new static readonly string MRClassNameKey;

		static vtkMedicalImageProperties()
		{
			vtkMedicalImageProperties.MRClassNameKey = "class vtkMedicalImageProperties";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMedicalImageProperties.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageProperties"));
		}

		public vtkMedicalImageProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMedicalImageProperties New()
		{
			vtkMedicalImageProperties result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMedicalImageProperties() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMedicalImageProperties.vtkMedicalImageProperties_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_AddUserDefinedValue_01(HandleRef pThis, string name, string value);

		public virtual void AddUserDefinedValue(string name, string value)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_AddUserDefinedValue_01(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_AddWindowLevelPreset_02(HandleRef pThis, double w, double l);

		public virtual int AddWindowLevelPreset(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_AddWindowLevelPreset_02(base.GetCppThis(), w, l);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_Clear_03(HandleRef pThis);

		public virtual void Clear()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_Clear_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_DeepCopy_04(HandleRef pThis, HandleRef p);

		public virtual void DeepCopy(vtkMedicalImageProperties p)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_DeepCopy_04(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionDate_05(HandleRef pThis);

		public virtual string GetAcquisitionDate()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDate_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateDay_06(HandleRef pThis);

		public int GetAcquisitionDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateDay_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateMonth_07(HandleRef pThis);

		public int GetAcquisitionDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateMonth_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateYear_08(HandleRef pThis);

		public int GetAcquisitionDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateYear_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionTime_09(HandleRef pThis);

		public virtual string GetAcquisitionTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionTime_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetAgeAsFields_10(string age, ref int year, ref int month, ref int week, ref int day);

		public static int GetAgeAsFields(string age, ref int year, ref int month, ref int week, ref int day)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAgeAsFields_10(age, ref year, ref month, ref week, ref day);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetConvolutionKernel_11(HandleRef pThis);

		public virtual string GetConvolutionKernel()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetConvolutionKernel_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetDateAsFields_12(string date, ref int year, ref int month, ref int day);

		public static int GetDateAsFields(string date, ref int year, ref int month, ref int day)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetDateAsFields_12(date, ref year, ref month, ref day);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetDateAsLocale_13(string date, string locale);

		public static int GetDateAsLocale(string date, string locale)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetDateAsLocale_13(date, locale);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetDirectionCosine_14(HandleRef pThis);

		public virtual double[] GetDirectionCosine()
		{
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_GetDirectionCosine_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		public virtual void GetDirectionCosine(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_GetDirectionCosine_16(HandleRef pThis, IntPtr _arg);

		public virtual void GetDirectionCosine(IntPtr _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetEchoTime_17(HandleRef pThis);

		public virtual string GetEchoTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetEchoTime_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetEchoTrainLength_18(HandleRef pThis);

		public virtual string GetEchoTrainLength()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetEchoTrainLength_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetExposure_19(HandleRef pThis);

		public virtual string GetExposure()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetExposure_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetExposureTime_20(HandleRef pThis);

		public virtual string GetExposureTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetExposureTime_20(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetGantryTilt_21(HandleRef pThis);

		public virtual string GetGantryTilt()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetGantryTilt_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMedicalImageProperties_GetGantryTiltAsDouble_22(HandleRef pThis);

		public virtual double GetGantryTiltAsDouble()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetGantryTiltAsDouble_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageDate_23(HandleRef pThis);

		public virtual string GetImageDate()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDate_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetImageDateDay_24(HandleRef pThis);

		public int GetImageDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateDay_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetImageDateMonth_25(HandleRef pThis);

		public int GetImageDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateMonth_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetImageDateYear_26(HandleRef pThis);

		public int GetImageDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateYear_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageNumber_27(HandleRef pThis);

		public virtual string GetImageNumber()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageNumber_27(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageTime_28(HandleRef pThis);

		public virtual string GetImageTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageTime_28(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(HandleRef pThis, int volumeidx, int sliceid);

		public string GetInstanceUIDFromSliceID(int volumeidx, int sliceid)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(base.GetCppThis(), volumeidx, sliceid));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetInstitutionName_30(HandleRef pThis);

		public virtual string GetInstitutionName()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetInstitutionName_30(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetKVP_31(HandleRef pThis);

		public virtual string GetKVP()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetKVP_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetManufacturer_32(HandleRef pThis);

		public virtual string GetManufacturer()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetManufacturer_32(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetManufacturerModelName_33(HandleRef pThis);

		public virtual string GetManufacturerModelName()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetManufacturerModelName_33(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetModality_34(HandleRef pThis);

		public virtual string GetModality()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetModality_34(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetNthWindowLevelPreset_35(HandleRef pThis, int idx, IntPtr w, IntPtr l);

		public virtual int GetNthWindowLevelPreset(int idx, IntPtr w, IntPtr l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPreset_35(base.GetCppThis(), idx, w, l);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPreset_36(HandleRef pThis, int idx);

		public virtual double[] GetNthWindowLevelPreset(int idx)
		{
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPreset_36(base.GetCppThis(), idx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(HandleRef pThis, int idx);

		public virtual string GetNthWindowLevelPresetComment(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkMedicalImageProperties_GetNumberOfUserDefinedValues_38(HandleRef pThis);

		public virtual uint GetNumberOfUserDefinedValues()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfUserDefinedValues_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_39(HandleRef pThis);

		public virtual int GetNumberOfWindowLevelPresets()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetOrientationType_40(HandleRef pThis, int volumeidx);

		public int GetOrientationType(int volumeidx)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetOrientationType_40(base.GetCppThis(), volumeidx);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientAge_41(HandleRef pThis);

		public virtual string GetPatientAge()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAge_41(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeDay_42(HandleRef pThis);

		public int GetPatientAgeDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeDay_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeMonth_43(HandleRef pThis);

		public int GetPatientAgeMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeMonth_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeWeek_44(HandleRef pThis);

		public int GetPatientAgeWeek()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeWeek_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeYear_45(HandleRef pThis);

		public int GetPatientAgeYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeYear_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientBirthDate_46(HandleRef pThis);

		public virtual string GetPatientBirthDate()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDate_46(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateDay_47(HandleRef pThis);

		public int GetPatientBirthDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateDay_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateMonth_48(HandleRef pThis);

		public int GetPatientBirthDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateMonth_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateYear_49(HandleRef pThis);

		public int GetPatientBirthDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateYear_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientID_50(HandleRef pThis);

		public virtual string GetPatientID()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientID_50(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientName_51(HandleRef pThis);

		public virtual string GetPatientName()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientName_51(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientSex_52(HandleRef pThis);

		public virtual string GetPatientSex()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientSex_52(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetRepetitionTime_53(HandleRef pThis);

		public virtual string GetRepetitionTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetRepetitionTime_53(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetSeriesDescription_54(HandleRef pThis);

		public virtual string GetSeriesDescription()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSeriesDescription_54(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetSeriesNumber_55(HandleRef pThis);

		public virtual string GetSeriesNumber()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSeriesNumber_55(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetSliceIDFromInstanceUID_56(HandleRef pThis, ref int volumeidx, string uid);

		public int GetSliceIDFromInstanceUID(ref int volumeidx, string uid)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceIDFromInstanceUID_56(base.GetCppThis(), ref volumeidx, uid);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetSliceThickness_57(HandleRef pThis);

		public virtual string GetSliceThickness()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceThickness_57(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMedicalImageProperties_GetSliceThicknessAsDouble_58(HandleRef pThis);

		public virtual double GetSliceThicknessAsDouble()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceThicknessAsDouble_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStationName_59(HandleRef pThis);

		public virtual string GetStationName()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStationName_59(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStringFromOrientationType_60(uint type);

		public static string GetStringFromOrientationType(uint type)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStringFromOrientationType_60(type));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyDate_61(HandleRef pThis);

		public virtual string GetStudyDate()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyDate_61(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyDescription_62(HandleRef pThis);

		public virtual string GetStudyDescription()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyDescription_62(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyID_63(HandleRef pThis);

		public virtual string GetStudyID()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyID_63(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyTime_64(HandleRef pThis);

		public virtual string GetStudyTime()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyTime_64(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetTimeAsFields_65(string time, ref int hour, ref int minute, ref int second);

		public static int GetTimeAsFields(string time, ref int hour, ref int minute, ref int second)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetTimeAsFields_65(time, ref hour, ref minute, ref second);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedNameByIndex_66(HandleRef pThis, uint idx);

		public virtual string GetUserDefinedNameByIndex(uint idx)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedNameByIndex_66(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValue_67(HandleRef pThis, string name);

		public virtual string GetUserDefinedValue(string name)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedValue_67(base.GetCppThis(), name));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValueByIndex_68(HandleRef pThis, uint idx);

		public virtual string GetUserDefinedValueByIndex(uint idx)
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedValueByIndex_68(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_GetWindowLevelPresetIndex_69(HandleRef pThis, double w, double l);

		public virtual int GetWindowLevelPresetIndex(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetWindowLevelPresetIndex_69(base.GetCppThis(), w, l);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_GetXRayTubeCurrent_70(HandleRef pThis);

		public virtual string GetXRayTubeCurrent()
		{
			return Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetXRayTubeCurrent_70(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_HasWindowLevelPreset_71(HandleRef pThis, double w, double l);

		public virtual int HasWindowLevelPreset(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_HasWindowLevelPreset_71(base.GetCppThis(), w, l);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_IsA_72(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_IsA_72(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMedicalImageProperties_IsTypeOf_73(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_IsTypeOf_73(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMedicalImageProperties NewInstance()
		{
			vtkMedicalImageProperties result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_NewInstance_75(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_RemoveAllUserDefinedValues_76(HandleRef pThis);

		public virtual void RemoveAllUserDefinedValues()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveAllUserDefinedValues_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_RemoveAllWindowLevelPresets_77(HandleRef pThis);

		public virtual void RemoveAllWindowLevelPresets()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveAllWindowLevelPresets_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_RemoveWindowLevelPreset_78(HandleRef pThis, double w, double l);

		public virtual void RemoveWindowLevelPreset(double w, double l)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveWindowLevelPreset_78(base.GetCppThis(), w, l);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMedicalImageProperties_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMedicalImageProperties SafeDownCast(vtkObjectBase o)
		{
			vtkMedicalImageProperties vtkMedicalImageProperties = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_SafeDownCast_79((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageProperties = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageProperties.Register(null);
				}
			}
			return vtkMedicalImageProperties;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetAcquisitionDate_80(HandleRef pThis, string _arg);

		public virtual void SetAcquisitionDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetAcquisitionDate_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetAcquisitionTime_81(HandleRef pThis, string _arg);

		public virtual void SetAcquisitionTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetAcquisitionTime_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetConvolutionKernel_82(HandleRef pThis, string _arg);

		public virtual void SetConvolutionKernel(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetConvolutionKernel_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetDirectionCosine_83(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetDirectionCosine(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetDirectionCosine_83(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetDirectionCosine_84(HandleRef pThis, IntPtr _arg);

		public virtual void SetDirectionCosine(IntPtr _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetDirectionCosine_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetEchoTime_85(HandleRef pThis, string _arg);

		public virtual void SetEchoTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetEchoTime_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetEchoTrainLength_86(HandleRef pThis, string _arg);

		public virtual void SetEchoTrainLength(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetEchoTrainLength_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetExposure_87(HandleRef pThis, string _arg);

		public virtual void SetExposure(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetExposure_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetExposureTime_88(HandleRef pThis, string _arg);

		public virtual void SetExposureTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetExposureTime_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetGantryTilt_89(HandleRef pThis, string _arg);

		public virtual void SetGantryTilt(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetGantryTilt_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetImageDate_90(HandleRef pThis, string _arg);

		public virtual void SetImageDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageDate_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetImageNumber_91(HandleRef pThis, string _arg);

		public virtual void SetImageNumber(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageNumber_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetImageTime_92(HandleRef pThis, string _arg);

		public virtual void SetImageTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageTime_92(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetInstanceUIDFromSliceID_93(HandleRef pThis, int volumeidx, int sliceid, string uid);

		public void SetInstanceUIDFromSliceID(int volumeidx, int sliceid, string uid)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetInstanceUIDFromSliceID_93(base.GetCppThis(), volumeidx, sliceid, uid);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetInstitutionName_94(HandleRef pThis, string _arg);

		public virtual void SetInstitutionName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetInstitutionName_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetKVP_95(HandleRef pThis, string _arg);

		public virtual void SetKVP(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetKVP_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetManufacturer_96(HandleRef pThis, string _arg);

		public virtual void SetManufacturer(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetManufacturer_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetManufacturerModelName_97(HandleRef pThis, string _arg);

		public virtual void SetManufacturerModelName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetManufacturerModelName_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetModality_98(HandleRef pThis, string _arg);

		public virtual void SetModality(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetModality_98(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetNthWindowLevelPresetComment_99(HandleRef pThis, int idx, string comment);

		public virtual void SetNthWindowLevelPresetComment(int idx, string comment)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetNthWindowLevelPresetComment_99(base.GetCppThis(), idx, comment);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetOrientationType_100(HandleRef pThis, int volumeidx, int orientation);

		public void SetOrientationType(int volumeidx, int orientation)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetOrientationType_100(base.GetCppThis(), volumeidx, orientation);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetPatientAge_101(HandleRef pThis, string _arg);

		public virtual void SetPatientAge(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientAge_101(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetPatientBirthDate_102(HandleRef pThis, string _arg);

		public virtual void SetPatientBirthDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientBirthDate_102(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetPatientID_103(HandleRef pThis, string _arg);

		public virtual void SetPatientID(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientID_103(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetPatientName_104(HandleRef pThis, string _arg);

		public virtual void SetPatientName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientName_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetPatientSex_105(HandleRef pThis, string _arg);

		public virtual void SetPatientSex(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientSex_105(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetRepetitionTime_106(HandleRef pThis, string _arg);

		public virtual void SetRepetitionTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetRepetitionTime_106(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetSeriesDescription_107(HandleRef pThis, string _arg);

		public virtual void SetSeriesDescription(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSeriesDescription_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetSeriesNumber_108(HandleRef pThis, string _arg);

		public virtual void SetSeriesNumber(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSeriesNumber_108(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetSliceThickness_109(HandleRef pThis, string _arg);

		public virtual void SetSliceThickness(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSliceThickness_109(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetStationName_110(HandleRef pThis, string _arg);

		public virtual void SetStationName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStationName_110(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetStudyDate_111(HandleRef pThis, string _arg);

		public virtual void SetStudyDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyDate_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetStudyDescription_112(HandleRef pThis, string _arg);

		public virtual void SetStudyDescription(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyDescription_112(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetStudyID_113(HandleRef pThis, string _arg);

		public virtual void SetStudyID(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyID_113(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetStudyTime_114(HandleRef pThis, string _arg);

		public virtual void SetStudyTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyTime_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMedicalImageProperties_SetXRayTubeCurrent_115(HandleRef pThis, string _arg);

		public virtual void SetXRayTubeCurrent(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetXRayTubeCurrent_115(base.GetCppThis(), _arg);
		}
	}
}
