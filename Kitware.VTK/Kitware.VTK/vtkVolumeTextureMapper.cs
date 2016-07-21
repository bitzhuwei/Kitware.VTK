using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkVolumeTextureMapper : vtkVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeTextureMapper";

		public new static readonly string MRClassNameKey;

		static vtkVolumeTextureMapper()
		{
			vtkVolumeTextureMapper.MRClassNameKey = "class vtkVolumeTextureMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeTextureMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeTextureMapper"));
		}

		public vtkVolumeTextureMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetBlueDiffuseShadingTable_01(HandleRef pThis);

		public IntPtr GetBlueDiffuseShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetBlueDiffuseShadingTable_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetBlueSpecularShadingTable_02(HandleRef pThis);

		public IntPtr GetBlueSpecularShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetBlueSpecularShadingTable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetDataOrigin_03(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetDataOrigin_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper_GetDataOrigin_04(HandleRef pThis, IntPtr data);

		public virtual void GetDataOrigin(IntPtr data)
		{
			vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetDataOrigin_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetDataSpacing_05(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetDataSpacing_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper_GetDataSpacing_06(HandleRef pThis, IntPtr data);

		public virtual void GetDataSpacing(IntPtr data)
		{
			vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetDataSpacing_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetEncodedNormals_07(HandleRef pThis);

		public IntPtr GetEncodedNormals()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetEncodedNormals_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGradientEstimator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEncodedGradientEstimator GetGradientEstimator()
		{
			vtkEncodedGradientEstimator vtkEncodedGradientEstimator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientEstimator_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientEstimator = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientEstimator.Register(null);
				}
			}
			return vtkEncodedGradientEstimator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper_GetGradientMagnitudeBias_09(HandleRef pThis);

		public override float GetGradientMagnitudeBias()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientMagnitudeBias_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper_GetGradientMagnitudeBias_10(HandleRef pThis, int arg0);

		public override float GetGradientMagnitudeBias(int arg0)
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientMagnitudeBias_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper_GetGradientMagnitudeScale_11(HandleRef pThis);

		public override float GetGradientMagnitudeScale()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientMagnitudeScale_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper_GetGradientMagnitudeScale_12(HandleRef pThis, int arg0);

		public override float GetGradientMagnitudeScale(int arg0)
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientMagnitudeScale_12(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGradientMagnitudes_13(HandleRef pThis);

		public IntPtr GetGradientMagnitudes()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientMagnitudes_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGradientOpacityArray_14(HandleRef pThis);

		public IntPtr GetGradientOpacityArray()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientOpacityArray_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGradientShader_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEncodedGradientShader GetGradientShader()
		{
			vtkEncodedGradientShader vtkEncodedGradientShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGradientShader_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientShader = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientShader.Register(null);
				}
			}
			return vtkEncodedGradientShader;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGreenDiffuseShadingTable_16(HandleRef pThis);

		public IntPtr GetGreenDiffuseShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGreenDiffuseShadingTable_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetGreenSpecularShadingTable_17(HandleRef pThis);

		public IntPtr GetGreenSpecularShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetGreenSpecularShadingTable_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetRGBAArray_18(HandleRef pThis);

		public IntPtr GetRGBAArray()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetRGBAArray_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetRedDiffuseShadingTable_19(HandleRef pThis);

		public IntPtr GetRedDiffuseShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetRedDiffuseShadingTable_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetRedSpecularShadingTable_20(HandleRef pThis);

		public IntPtr GetRedSpecularShadingTable()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetRedSpecularShadingTable_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_GetRenderWindow_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetRenderWindow_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper_GetShade_22(HandleRef pThis);

		public virtual int GetShade()
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_GetShade_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeTextureMapper.vtkVolumeTextureMapper_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeTextureMapper NewInstance()
		{
			vtkVolumeTextureMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTextureMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper_Render_26(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkVolumeTextureMapper.vtkVolumeTextureMapper_Render_26(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeTextureMapper SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeTextureMapper vtkVolumeTextureMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper.vtkVolumeTextureMapper_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeTextureMapper = (vtkVolumeTextureMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeTextureMapper.Register(null);
				}
			}
			return vtkVolumeTextureMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper_SetGradientEstimator_28(HandleRef pThis, HandleRef gradest);

		public virtual void SetGradientEstimator(vtkEncodedGradientEstimator gradest)
		{
			vtkVolumeTextureMapper.vtkVolumeTextureMapper_SetGradientEstimator_28(base.GetCppThis(), (gradest == null) ? default(HandleRef) : gradest.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper_Update_29(HandleRef pThis);

		public override void Update()
		{
			vtkVolumeTextureMapper.vtkVolumeTextureMapper_Update_29(base.GetCppThis());
		}
	}
}
