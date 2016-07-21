using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractVolumeMapper : vtkAbstractMapper3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkAbstractVolumeMapper()
		{
			vtkAbstractVolumeMapper.MRClassNameKey = "class vtkAbstractVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractVolumeMapper"));
		}

		public vtkAbstractVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractVolumeMapper_GetArrayAccessMode_01(HandleRef pThis);

		public virtual int GetArrayAccessMode()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayAccessMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractVolumeMapper_GetArrayId_02(HandleRef pThis);

		public virtual int GetArrayId()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayId_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetArrayName_03(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetBounds_04(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetBounds_05(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetDataObjectInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetDataObjectInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetDataObjectInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetDataSetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetDataSetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetDataSetInput_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(HandleRef pThis);

		public virtual float GetGradientMagnitudeBias()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(HandleRef pThis, int arg0);

		public virtual float GetGradientMagnitudeBias(int arg0)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(HandleRef pThis);

		public virtual float GetGradientMagnitudeScale()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(HandleRef pThis, int arg0);

		public virtual float GetGradientMagnitudeScale(int arg0)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractVolumeMapper_GetScalarMode_12(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetScalarMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetScalarModeAsString_13(HandleRef pThis);

		public string GetScalarModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetScalarModeAsString_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractVolumeMapper_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractVolumeMapper_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractVolumeMapper NewInstance()
		{
			vtkAbstractVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_Render_18(HandleRef pThis, HandleRef ren, HandleRef vol);

		public virtual void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_Render_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractVolumeMapper_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractVolumeMapper vtkAbstractVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractVolumeMapper = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractVolumeMapper.Register(null);
				}
			}
			return vtkAbstractVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_20(HandleRef pThis, int arrayNum);

		public virtual void SelectScalarArray(int arrayNum)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SelectScalarArray_20(base.GetCppThis(), arrayNum);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_21(HandleRef pThis, string arrayName);

		public virtual void SelectScalarArray(string arrayName)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SelectScalarArray_21(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetInput_22(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkDataSet arg0)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetInput_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarMode_23(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarMode_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToDefault_24(HandleRef pThis);

		public void SetScalarModeToDefault()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToDefault_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellData_25(HandleRef pThis);

		public void SetScalarModeToUseCellData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUseCellData_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_26(HandleRef pThis);

		public void SetScalarModeToUseCellFieldData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointData_27(HandleRef pThis);

		public void SetScalarModeToUsePointData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUsePointData_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_28(HandleRef pThis);

		public void SetScalarModeToUsePointFieldData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_28(base.GetCppThis());
		}
	}
}
