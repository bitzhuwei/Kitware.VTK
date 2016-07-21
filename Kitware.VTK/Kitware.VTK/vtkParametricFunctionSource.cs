using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricFunctionSource : vtkPolyDataAlgorithm
	{
		public enum SCALAR_MODE
		{
			SCALAR_DISTANCE = 12,
			SCALAR_FUNCTION_DEFINED,
			SCALAR_MODULUS = 6,
			SCALAR_NONE = 0,
			SCALAR_PHASE = 7,
			SCALAR_QUADRANT,
			SCALAR_U = 1,
			SCALAR_U0 = 3,
			SCALAR_U0V0 = 5,
			SCALAR_V = 2,
			SCALAR_V0 = 4,
			SCALAR_X = 9,
			SCALAR_Y,
			SCALAR_Z
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunctionSource";

		public new static readonly string MRClassNameKey;

		static vtkParametricFunctionSource()
		{
			vtkParametricFunctionSource.MRClassNameKey = "class vtkParametricFunctionSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricFunctionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunctionSource"));
		}

		public vtkParametricFunctionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunctionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricFunctionSource New()
		{
			vtkParametricFunctionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricFunctionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricFunctionSource.vtkParametricFunctionSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOff_01(HandleRef pThis);

		public virtual void GenerateTextureCoordinatesOff()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateTextureCoordinatesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOn_02(HandleRef pThis);

		public virtual void GenerateTextureCoordinatesOn()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_GenerateTextureCoordinatesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinates_03(HandleRef pThis);

		public virtual int GetGenerateTextureCoordinates()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetGenerateTextureCoordinates_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkParametricFunctionSource_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunctionSource_GetParametricFunction_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkParametricFunction GetParametricFunction()
		{
			vtkParametricFunction vtkParametricFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_GetParametricFunction_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunction = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunction.Register(null);
				}
			}
			return vtkParametricFunction;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetScalarMode_06(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetScalarModeMaxValue_07(HandleRef pThis);

		public virtual int GetScalarModeMaxValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarModeMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetScalarModeMinValue_08(HandleRef pThis);

		public virtual int GetScalarModeMinValue()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetScalarModeMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetUResolution_09(HandleRef pThis);

		public virtual int GetUResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetUResolution_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetVResolution_10(HandleRef pThis);

		public virtual int GetVResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetVResolution_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_GetWResolution_11(HandleRef pThis);

		public virtual int GetWResolution()
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_GetWResolution_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkParametricFunctionSource_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricFunctionSource.vtkParametricFunctionSource_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunctionSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricFunctionSource NewInstance()
		{
			vtkParametricFunctionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricFunctionSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricFunctionSource SafeDownCast(vtkObjectBase o)
		{
			vtkParametricFunctionSource vtkParametricFunctionSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricFunctionSource.vtkParametricFunctionSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunctionSource = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunctionSource.Register(null);
				}
			}
			return vtkParametricFunctionSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetGenerateTextureCoordinates_17(HandleRef pThis, int _arg);

		public virtual void SetGenerateTextureCoordinates(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetGenerateTextureCoordinates_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetParametricFunction_18(HandleRef pThis, HandleRef arg0);

		public virtual void SetParametricFunction(vtkParametricFunction arg0)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetParametricFunction_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarMode_19(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarMode_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToDistance_20(HandleRef pThis);

		public void SetScalarModeToDistance()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToDistance_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToFunctionDefined_21(HandleRef pThis);

		public void SetScalarModeToFunctionDefined()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToFunctionDefined_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToModulus_22(HandleRef pThis);

		public void SetScalarModeToModulus()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToModulus_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToNone_23(HandleRef pThis);

		public void SetScalarModeToNone()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToNone_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToPhase_24(HandleRef pThis);

		public void SetScalarModeToPhase()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToPhase_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToQuadrant_25(HandleRef pThis);

		public void SetScalarModeToQuadrant()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToQuadrant_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU_26(HandleRef pThis);

		public void SetScalarModeToU()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU0_27(HandleRef pThis);

		public void SetScalarModeToU0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU0_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToU0V0_28(HandleRef pThis);

		public void SetScalarModeToU0V0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToU0V0_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToV_29(HandleRef pThis);

		public void SetScalarModeToV()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToV_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToV0_30(HandleRef pThis);

		public void SetScalarModeToV0()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToV0_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToX_31(HandleRef pThis);

		public void SetScalarModeToX()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToX_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToY_32(HandleRef pThis);

		public void SetScalarModeToY()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToY_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetScalarModeToZ_33(HandleRef pThis);

		public void SetScalarModeToZ()
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetScalarModeToZ_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetUResolution_34(HandleRef pThis, int _arg);

		public virtual void SetUResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetUResolution_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetVResolution_35(HandleRef pThis, int _arg);

		public virtual void SetVResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetVResolution_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkParametricFunctionSource_SetWResolution_36(HandleRef pThis, int _arg);

		public virtual void SetWResolution(int _arg)
		{
			vtkParametricFunctionSource.vtkParametricFunctionSource_SetWResolution_36(base.GetCppThis(), _arg);
		}
	}
}
