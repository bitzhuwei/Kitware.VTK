using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEncodedGradientShader : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEncodedGradientShader";

		public new static readonly string MRClassNameKey;

		static vtkEncodedGradientShader()
		{
			vtkEncodedGradientShader.MRClassNameKey = "class vtkEncodedGradientShader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEncodedGradientShader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEncodedGradientShader"));
		}

		public vtkEncodedGradientShader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEncodedGradientShader New()
		{
			vtkEncodedGradientShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEncodedGradientShader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEncodedGradientShader.vtkEncodedGradientShader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientShader_GetActiveComponent_01(HandleRef pThis);

		public virtual int GetActiveComponent()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponent_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientShader_GetActiveComponentMaxValue_02(HandleRef pThis);

		public virtual int GetActiveComponentMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponentMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientShader_GetActiveComponentMinValue_03(HandleRef pThis);

		public virtual int GetActiveComponentMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetActiveComponentMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(HandleRef pThis, HandleRef vol);

		public IntPtr GetBlueDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetBlueDiffuseShadingTable_04(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(HandleRef pThis, HandleRef vol);

		public IntPtr GetBlueSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetBlueSpecularShadingTable_05(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(HandleRef pThis, HandleRef vol);

		public IntPtr GetGreenDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetGreenDiffuseShadingTable_06(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(HandleRef pThis, HandleRef vol);

		public IntPtr GetGreenSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetGreenSpecularShadingTable_07(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetRedDiffuseShadingTable_08(HandleRef pThis, HandleRef vol);

		public IntPtr GetRedDiffuseShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetRedDiffuseShadingTable_08(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_GetRedSpecularShadingTable_09(HandleRef pThis, HandleRef vol);

		public IntPtr GetRedSpecularShadingTable(vtkVolume vol)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetRedSpecularShadingTable_09(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_10(HandleRef pThis);

		public virtual float GetZeroNormalDiffuseIntensity()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensity_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_11(HandleRef pThis);

		public virtual float GetZeroNormalDiffuseIntensityMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_12(HandleRef pThis);

		public virtual float GetZeroNormalDiffuseIntensityMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalDiffuseIntensityMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_13(HandleRef pThis);

		public virtual float GetZeroNormalSpecularIntensity()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensity_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_14(HandleRef pThis);

		public virtual float GetZeroNormalSpecularIntensityMaxValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_15(HandleRef pThis);

		public virtual float GetZeroNormalSpecularIntensityMinValue()
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_GetZeroNormalSpecularIntensityMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientShader_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkEncodedGradientShader_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEncodedGradientShader.vtkEncodedGradientShader_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEncodedGradientShader NewInstance()
		{
			vtkEncodedGradientShader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkEncodedGradientShader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEncodedGradientShader SafeDownCast(vtkObjectBase o)
		{
			vtkEncodedGradientShader vtkEncodedGradientShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEncodedGradientShader.vtkEncodedGradientShader_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkEncodedGradientShader_SetActiveComponent_21(HandleRef pThis, int _arg);

		public virtual void SetActiveComponent(int _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetActiveComponent_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_22(HandleRef pThis, float _arg);

		public virtual void SetZeroNormalDiffuseIntensity(float _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetZeroNormalDiffuseIntensity_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_23(HandleRef pThis, float _arg);

		public virtual void SetZeroNormalSpecularIntensity(float _arg)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_SetZeroNormalSpecularIntensity_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkEncodedGradientShader_UpdateShadingTable_24(HandleRef pThis, HandleRef ren, HandleRef vol, HandleRef gradest);

		public void UpdateShadingTable(vtkRenderer ren, vtkVolume vol, vtkEncodedGradientEstimator gradest)
		{
			vtkEncodedGradientShader.vtkEncodedGradientShader_UpdateShadingTable_24(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (gradest == null) ? default(HandleRef) : gradest.GetCppThis());
		}
	}
}
