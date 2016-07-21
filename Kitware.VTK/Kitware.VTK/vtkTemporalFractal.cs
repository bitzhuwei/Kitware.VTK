using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalFractal : vtkTemporalDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalFractal";

		public new static readonly string MRClassNameKey;

		static vtkTemporalFractal()
		{
			vtkTemporalFractal.MRClassNameKey = "class vtkTemporalFractal";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalFractal.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalFractal"));
		}

		public vtkTemporalFractal(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalFractal_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalFractal New()
		{
			vtkTemporalFractal result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalFractal() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalFractal.vtkTemporalFractal_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOff_01(HandleRef pThis);

		public virtual void AdaptiveSubdivisionOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_AdaptiveSubdivisionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_AdaptiveSubdivisionOn_02(HandleRef pThis);

		public virtual void AdaptiveSubdivisionOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_AdaptiveSubdivisionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_DiscreteTimeStepsOff_03(HandleRef pThis);

		public virtual void DiscreteTimeStepsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_DiscreteTimeStepsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_DiscreteTimeStepsOn_04(HandleRef pThis);

		public virtual void DiscreteTimeStepsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_DiscreteTimeStepsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOff_05(HandleRef pThis);

		public virtual void GenerateRectilinearGridsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_GenerateRectilinearGridsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_GenerateRectilinearGridsOn_06(HandleRef pThis);

		public virtual void GenerateRectilinearGridsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_GenerateRectilinearGridsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetAdaptiveSubdivision_07(HandleRef pThis);

		public virtual int GetAdaptiveSubdivision()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetAdaptiveSubdivision_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetAsymetric_08(HandleRef pThis);

		public virtual int GetAsymetric()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetAsymetric_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetDimensions_09(HandleRef pThis);

		public virtual int GetDimensions()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetDimensions_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetDiscreteTimeSteps_10(HandleRef pThis);

		public virtual int GetDiscreteTimeSteps()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetDiscreteTimeSteps_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern float vtkTemporalFractal_GetFractalValue_11(HandleRef pThis);

		public virtual float GetFractalValue()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetFractalValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetGenerateRectilinearGrids_12(HandleRef pThis);

		public virtual int GetGenerateRectilinearGrids()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetGenerateRectilinearGrids_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetGhostLevels_13(HandleRef pThis);

		public virtual int GetGhostLevels()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetGhostLevels_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetMaximumLevel_14(HandleRef pThis);

		public virtual int GetMaximumLevel()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetMaximumLevel_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_GetTwoDimensional_15(HandleRef pThis);

		public virtual int GetTwoDimensional()
		{
			return vtkTemporalFractal.vtkTemporalFractal_GetTwoDimensional_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_GhostLevelsOff_16(HandleRef pThis);

		public virtual void GhostLevelsOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_GhostLevelsOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_GhostLevelsOn_17(HandleRef pThis);

		public virtual void GhostLevelsOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_GhostLevelsOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTemporalFractal_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalFractal.vtkTemporalFractal_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalFractal_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalFractal NewInstance()
		{
			vtkTemporalFractal result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalFractal_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalFractal SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalFractal vtkTemporalFractal = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalFractal.vtkTemporalFractal_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalFractal = (vtkTemporalFractal)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalFractal.Register(null);
				}
			}
			return vtkTemporalFractal;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetAdaptiveSubdivision_23(HandleRef pThis, int _arg);

		public virtual void SetAdaptiveSubdivision(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetAdaptiveSubdivision_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetAsymetric_24(HandleRef pThis, int _arg);

		public virtual void SetAsymetric(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetAsymetric_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetDimensions_25(HandleRef pThis, int _arg);

		public virtual void SetDimensions(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetDimensions_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetDiscreteTimeSteps_26(HandleRef pThis, int _arg);

		public virtual void SetDiscreteTimeSteps(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetDiscreteTimeSteps_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetFractalValue_27(HandleRef pThis, float _arg);

		public virtual void SetFractalValue(float _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetFractalValue_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetGenerateRectilinearGrids_28(HandleRef pThis, int _arg);

		public virtual void SetGenerateRectilinearGrids(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetGenerateRectilinearGrids_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetGhostLevels_29(HandleRef pThis, int _arg);

		public virtual void SetGhostLevels(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetGhostLevels_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetMaximumLevel_30(HandleRef pThis, int _arg);

		public virtual void SetMaximumLevel(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetMaximumLevel_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_SetTwoDimensional_31(HandleRef pThis, int _arg);

		public virtual void SetTwoDimensional(int _arg)
		{
			vtkTemporalFractal.vtkTemporalFractal_SetTwoDimensional_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_TwoDimensionalOff_32(HandleRef pThis);

		public virtual void TwoDimensionalOff()
		{
			vtkTemporalFractal.vtkTemporalFractal_TwoDimensionalOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTemporalFractal_TwoDimensionalOn_33(HandleRef pThis);

		public virtual void TwoDimensionalOn()
		{
			vtkTemporalFractal.vtkTemporalFractal_TwoDimensionalOn_33(base.GetCppThis());
		}
	}
}
