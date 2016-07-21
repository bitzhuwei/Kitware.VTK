using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParametricRandomHills : vtkParametricFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParametricRandomHills";

		public new static readonly string MRClassNameKey;

		static vtkParametricRandomHills()
		{
			vtkParametricRandomHills.MRClassNameKey = "class vtkParametricRandomHills";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParametricRandomHills.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricRandomHills"));
		}

		public vtkParametricRandomHills(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricRandomHills_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricRandomHills New()
		{
			vtkParametricRandomHills result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParametricRandomHills() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParametricRandomHills.vtkParametricRandomHills_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_AllowRandomGenerationOff_01(HandleRef pThis);

		public virtual void AllowRandomGenerationOff()
		{
			vtkParametricRandomHills.vtkParametricRandomHills_AllowRandomGenerationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_AllowRandomGenerationOn_02(HandleRef pThis);

		public virtual void AllowRandomGenerationOn()
		{
			vtkParametricRandomHills.vtkParametricRandomHills_AllowRandomGenerationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_Evaluate_03(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override void Evaluate(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_Evaluate_03(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_EvaluateScalar_04(HandleRef pThis, IntPtr uvw, IntPtr Pt, IntPtr Duvw);

		public override double EvaluateScalar(IntPtr uvw, IntPtr Pt, IntPtr Duvw)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_EvaluateScalar_04(base.GetCppThis(), uvw, Pt, Duvw);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_GenerateTheHills_05(HandleRef pThis);

		public void GenerateTheHills()
		{
			vtkParametricRandomHills.vtkParametricRandomHills_GenerateTheHills_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_GetAllowRandomGeneration_06(HandleRef pThis);

		public virtual int GetAllowRandomGeneration()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAllowRandomGeneration_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetAmplitudeScaleFactor_07(HandleRef pThis);

		public virtual double GetAmplitudeScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetAmplitudeScaleFactor_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_GetDimension_08(HandleRef pThis);

		public override int GetDimension()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetDimension_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetHillAmplitude_09(HandleRef pThis);

		public virtual double GetHillAmplitude()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillAmplitude_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetHillXVariance_10(HandleRef pThis);

		public virtual double GetHillXVariance()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillXVariance_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetHillYVariance_11(HandleRef pThis);

		public virtual double GetHillYVariance()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetHillYVariance_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_GetNumberOfHills_12(HandleRef pThis);

		public virtual int GetNumberOfHills()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetNumberOfHills_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_GetRandomSeed_13(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetRandomSeed_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetXVarianceScaleFactor_14(HandleRef pThis);

		public virtual double GetXVarianceScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetXVarianceScaleFactor_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkParametricRandomHills_GetYVarianceScaleFactor_15(HandleRef pThis);

		public virtual double GetYVarianceScaleFactor()
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_GetYVarianceScaleFactor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkParametricRandomHills_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParametricRandomHills.vtkParametricRandomHills_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricRandomHills_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParametricRandomHills NewInstance()
		{
			vtkParametricRandomHills result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkParametricRandomHills_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParametricRandomHills SafeDownCast(vtkObjectBase o)
		{
			vtkParametricRandomHills vtkParametricRandomHills = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParametricRandomHills.vtkParametricRandomHills_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricRandomHills = (vtkParametricRandomHills)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricRandomHills.Register(null);
				}
			}
			return vtkParametricRandomHills;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetAllowRandomGeneration_21(HandleRef pThis, int _arg);

		public virtual void SetAllowRandomGeneration(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetAllowRandomGeneration_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetAmplitudeScaleFactor_22(HandleRef pThis, double _arg);

		public virtual void SetAmplitudeScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetAmplitudeScaleFactor_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetHillAmplitude_23(HandleRef pThis, double _arg);

		public virtual void SetHillAmplitude(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillAmplitude_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetHillXVariance_24(HandleRef pThis, double _arg);

		public virtual void SetHillXVariance(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillXVariance_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetHillYVariance_25(HandleRef pThis, double _arg);

		public virtual void SetHillYVariance(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetHillYVariance_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetNumberOfHills_26(HandleRef pThis, int _arg);

		public virtual void SetNumberOfHills(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetNumberOfHills_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetRandomSeed_27(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetRandomSeed_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetXVarianceScaleFactor_28(HandleRef pThis, double _arg);

		public virtual void SetXVarianceScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetXVarianceScaleFactor_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkParametricRandomHills_SetYVarianceScaleFactor_29(HandleRef pThis, double _arg);

		public virtual void SetYVarianceScaleFactor(double _arg)
		{
			vtkParametricRandomHills.vtkParametricRandomHills_SetYVarianceScaleFactor_29(base.GetCppThis(), _arg);
		}
	}
}
