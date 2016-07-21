using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDEMReader : vtkImageAlgorithm
	{
		public enum REFERENCE_ELEVATION_BOUNDS_WrapperEnum
		{
			REFERENCE_ELEVATION_BOUNDS = 1,
			REFERENCE_SEA_LEVEL = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDEMReader";

		public new static readonly string MRClassNameKey;

		static vtkDEMReader()
		{
			vtkDEMReader.MRClassNameKey = "class vtkDEMReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDEMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDEMReader"));
		}

		public vtkDEMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDEMReader New()
		{
			vtkDEMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDEMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDEMReader.vtkDEMReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetAccuracyCode_01(HandleRef pThis);

		public virtual int GetAccuracyCode()
		{
			return vtkDEMReader.vtkDEMReader_GetAccuracyCode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetDEMLevel_02(HandleRef pThis);

		public virtual int GetDEMLevel()
		{
			return vtkDEMReader.vtkDEMReader_GetDEMLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetElevationBounds_03(HandleRef pThis);

		public virtual float[] GetElevationBounds()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetElevationBounds_03(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_GetElevationBounds_04(HandleRef pThis, IntPtr data);

		public virtual void GetElevationBounds(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetElevationBounds_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetElevationPattern_05(HandleRef pThis);

		public virtual int GetElevationPattern()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationPattern_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetElevationReference_06(HandleRef pThis);

		public virtual int GetElevationReference()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReference_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetElevationReferenceAsString_07(HandleRef pThis);

		public string GetElevationReferenceAsString()
		{
			return Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetElevationReferenceAsString_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetElevationReferenceMaxValue_08(HandleRef pThis);

		public virtual int GetElevationReferenceMaxValue()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReferenceMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetElevationReferenceMinValue_09(HandleRef pThis);

		public virtual int GetElevationReferenceMinValue()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationReferenceMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetElevationUnitOfMeasure_10(HandleRef pThis);

		public virtual int GetElevationUnitOfMeasure()
		{
			return vtkDEMReader.vtkDEMReader_GetElevationUnitOfMeasure_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetFileName_11(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetGroundSystem_12(HandleRef pThis);

		public virtual int GetGroundSystem()
		{
			return vtkDEMReader.vtkDEMReader_GetGroundSystem_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetGroundZone_13(HandleRef pThis);

		public virtual int GetGroundZone()
		{
			return vtkDEMReader.vtkDEMReader_GetGroundZone_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern float vtkDEMReader_GetLocalRotation_14(HandleRef pThis);

		public virtual float GetLocalRotation()
		{
			return vtkDEMReader.vtkDEMReader_GetLocalRotation_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetMapLabel_15(HandleRef pThis);

		public virtual string GetMapLabel()
		{
			return Marshal.PtrToStringAnsi(vtkDEMReader.vtkDEMReader_GetMapLabel_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetPlaneUnitOfMeasure_16(HandleRef pThis);

		public virtual int GetPlaneUnitOfMeasure()
		{
			return vtkDEMReader.vtkDEMReader_GetPlaneUnitOfMeasure_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_GetPolygonSize_17(HandleRef pThis);

		public virtual int GetPolygonSize()
		{
			return vtkDEMReader.vtkDEMReader_GetPolygonSize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetProfileDimension_18(HandleRef pThis);

		public virtual int[] GetProfileDimension()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetProfileDimension_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_GetProfileDimension_19(HandleRef pThis, IntPtr data);

		public virtual void GetProfileDimension(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetProfileDimension_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetProjectionParameters_20(HandleRef pThis);

		public virtual float[] GetProjectionParameters()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetProjectionParameters_20(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[5];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_GetProjectionParameters_21(HandleRef pThis, IntPtr data);

		public virtual void GetProjectionParameters(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetProjectionParameters_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_GetSpatialResolution_22(HandleRef pThis);

		public virtual float[] GetSpatialResolution()
		{
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_GetSpatialResolution_22(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_GetSpatialResolution_23(HandleRef pThis, IntPtr data);

		public virtual void GetSpatialResolution(IntPtr data)
		{
			vtkDEMReader.vtkDEMReader_GetSpatialResolution_23(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDEMReader.vtkDEMReader_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDEMReader_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDEMReader.vtkDEMReader_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDEMReader NewInstance()
		{
			vtkDEMReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDEMReader_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDEMReader SafeDownCast(vtkObjectBase o)
		{
			vtkDEMReader vtkDEMReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDEMReader.vtkDEMReader_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDEMReader = (vtkDEMReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDEMReader.Register(null);
				}
			}
			return vtkDEMReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_SetElevationReference_29(HandleRef pThis, int _arg);

		public virtual void SetElevationReference(int _arg)
		{
			vtkDEMReader.vtkDEMReader_SetElevationReference_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_SetElevationReferenceToElevationBounds_30(HandleRef pThis);

		public void SetElevationReferenceToElevationBounds()
		{
			vtkDEMReader.vtkDEMReader_SetElevationReferenceToElevationBounds_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_SetElevationReferenceToSeaLevel_31(HandleRef pThis);

		public void SetElevationReferenceToSeaLevel()
		{
			vtkDEMReader.vtkDEMReader_SetElevationReferenceToSeaLevel_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDEMReader_SetFileName_32(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDEMReader.vtkDEMReader_SetFileName_32(base.GetCppThis(), _arg);
		}
	}
}
