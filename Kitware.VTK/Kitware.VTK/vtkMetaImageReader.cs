using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMetaImageReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageReader";

		public new static readonly string MRClassNameKey;

		static vtkMetaImageReader()
		{
			vtkMetaImageReader.MRClassNameKey = "class vtkMetaImageReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMetaImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageReader"));
		}

		public vtkMetaImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMetaImageReader New()
		{
			vtkMetaImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMetaImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMetaImageReader.vtkMetaImageReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_CanReadFile_01(HandleRef pThis, string name);

		public override int CanReadFile(string name)
		{
			return vtkMetaImageReader.vtkMetaImageReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetAnatomicalOrientation_02(HandleRef pThis);

		public virtual string GetAnatomicalOrientation()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetAnatomicalOrientation_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetBitsAllocated_03(HandleRef pThis);

		public virtual int GetBitsAllocated()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetBitsAllocated_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetDataByteOrder_04(HandleRef pThis);

		public override int GetDataByteOrder()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetDataByteOrder_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetDate_05(HandleRef pThis);

		public virtual string GetDate()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDate_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetDescriptiveName_06(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDescriptiveName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetDistanceUnits_07(HandleRef pThis);

		public virtual string GetDistanceUnits()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDistanceUnits_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetFileExtensions_08(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetFileExtensions_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMetaImageReader_GetGantryAngle_09(HandleRef pThis);

		public virtual double GetGantryAngle()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetGantryAngle_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetHeight_10(HandleRef pThis);

		public int GetHeight()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetHeight_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetImageNumber_11(HandleRef pThis);

		public virtual string GetImageNumber()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetImageNumber_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetImagePositionPatient_12(HandleRef pThis);

		public IntPtr GetImagePositionPatient()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetImagePositionPatient_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetModality_13(HandleRef pThis);

		public virtual string GetModality()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetModality_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetNumberOfComponents_14(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetNumberOfComponents_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetPatientID_15(HandleRef pThis);

		public virtual string GetPatientID()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetPatientID_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetPatientName_16(HandleRef pThis);

		public virtual string GetPatientName()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetPatientName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetPixelRepresentation_17(HandleRef pThis);

		public int GetPixelRepresentation()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetPixelRepresentation_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetPixelSpacing_18(HandleRef pThis);

		public IntPtr GetPixelSpacing()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetPixelSpacing_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMetaImageReader_GetRescaleOffset_19(HandleRef pThis);

		public virtual double GetRescaleOffset()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetRescaleOffset_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMetaImageReader_GetRescaleSlope_20(HandleRef pThis);

		public virtual double GetRescaleSlope()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetRescaleSlope_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetSeries_21(HandleRef pThis);

		public virtual string GetSeries()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetSeries_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetStudyID_22(HandleRef pThis);

		public virtual string GetStudyID()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetStudyID_22(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetStudyUID_23(HandleRef pThis);

		public virtual string GetStudyUID()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetStudyUID_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_GetTransferSyntaxUID_24(HandleRef pThis);

		public virtual string GetTransferSyntaxUID()
		{
			return Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetTransferSyntaxUID_24(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_GetWidth_25(HandleRef pThis);

		public int GetWidth()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetWidth_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMetaImageReader_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMetaImageReader NewInstance()
		{
			vtkMetaImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMetaImageReader_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMetaImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkMetaImageReader vtkMetaImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMetaImageReader = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMetaImageReader.Register(null);
				}
			}
			return vtkMetaImageReader;
		}
	}
}
