using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDICOMImageReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMImageReader";

		public new static readonly string MRClassNameKey;

		static vtkDICOMImageReader()
		{
			vtkDICOMImageReader.MRClassNameKey = "class vtkDICOMImageReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMImageReader"));
		}

		public vtkDICOMImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDICOMImageReader New()
		{
			vtkDICOMImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDICOMImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDICOMImageReader.vtkDICOMImageReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_CanReadFile_01(HandleRef pThis, string fname);

		public override int CanReadFile(string fname)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_GetBitsAllocated_02(HandleRef pThis);

		public int GetBitsAllocated()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetBitsAllocated_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetDescriptiveName_03(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetDescriptiveName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetDirectoryName_04(HandleRef pThis);

		public virtual string GetDirectoryName()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetDirectoryName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetFileExtensions_05(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetFileExtensions_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkDICOMImageReader_GetGantryAngle_06(HandleRef pThis);

		public float GetGantryAngle()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetGantryAngle_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_GetHeight_07(HandleRef pThis);

		public int GetHeight()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetHeight_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetImageOrientationPatient_08(HandleRef pThis);

		public float[] GetImageOrientationPatient()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetImageOrientationPatient_08(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetImagePositionPatient_09(HandleRef pThis);

		public float[] GetImagePositionPatient()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetImagePositionPatient_09(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_GetNumberOfComponents_10(HandleRef pThis);

		public int GetNumberOfComponents()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetNumberOfComponents_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetPatientName_11(HandleRef pThis);

		public string GetPatientName()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetPatientName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_GetPixelRepresentation_12(HandleRef pThis);

		public int GetPixelRepresentation()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetPixelRepresentation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetPixelSpacing_13(HandleRef pThis);

		public double[] GetPixelSpacing()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetPixelSpacing_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkDICOMImageReader_GetRescaleOffset_14(HandleRef pThis);

		public float GetRescaleOffset()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetRescaleOffset_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkDICOMImageReader_GetRescaleSlope_15(HandleRef pThis);

		public float GetRescaleSlope()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetRescaleSlope_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetStudyID_16(HandleRef pThis);

		public string GetStudyID()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetStudyID_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetStudyUID_17(HandleRef pThis);

		public string GetStudyUID()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetStudyUID_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_GetTransferSyntaxUID_18(HandleRef pThis);

		public string GetTransferSyntaxUID()
		{
			return Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetTransferSyntaxUID_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_GetWidth_19(HandleRef pThis);

		public int GetWidth()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetWidth_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDICOMImageReader_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDICOMImageReader NewInstance()
		{
			vtkDICOMImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDICOMImageReader_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDICOMImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMImageReader vtkDICOMImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMImageReader = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMImageReader.Register(null);
				}
			}
			return vtkDICOMImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDICOMImageReader_SetDirectoryName_25(HandleRef pThis, string dn);

		public void SetDirectoryName(string dn)
		{
			vtkDICOMImageReader.vtkDICOMImageReader_SetDirectoryName_25(base.GetCppThis(), dn);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDICOMImageReader_SetFileName_26(HandleRef pThis, string fn);

		public override void SetFileName(string fn)
		{
			vtkDICOMImageReader.vtkDICOMImageReader_SetFileName_26(base.GetCppThis(), fn);
		}
	}
}
