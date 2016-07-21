using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitSelectionLoop : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSelectionLoop";

		public new static readonly string MRClassNameKey;

		static vtkImplicitSelectionLoop()
		{
			vtkImplicitSelectionLoop.MRClassNameKey = "class vtkImplicitSelectionLoop";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitSelectionLoop.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSelectionLoop"));
		}

		public vtkImplicitSelectionLoop(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSelectionLoop_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitSelectionLoop New()
		{
			vtkImplicitSelectionLoop result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitSelectionLoop() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(HandleRef pThis);

		public virtual void AutomaticNormalGenerationOff()
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_AutomaticNormalGenerationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(HandleRef pThis);

		public virtual void AutomaticNormalGenerationOn()
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_AutomaticNormalGenerationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitSelectionLoop_EvaluateFunction_03(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_EvaluateFunction_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitSelectionLoop_EvaluateFunction_04(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_EvaluateFunction_04(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_EvaluateGradient_05(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_EvaluateGradient_05(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_06(HandleRef pThis);

		public virtual int GetAutomaticNormalGeneration()
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetAutomaticNormalGeneration_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSelectionLoop_GetLoop_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetLoop()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetLoop_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitSelectionLoop_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSelectionLoop_GetNormal_09(HandleRef pThis);

		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_GetNormal_10(HandleRef pThis, IntPtr data);

		public virtual void GetNormal(IntPtr data)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_GetNormal_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSelectionLoop_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSelectionLoop_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSelectionLoop_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitSelectionLoop NewInstance()
		{
			vtkImplicitSelectionLoop result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSelectionLoop_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitSelectionLoop SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitSelectionLoop vtkImplicitSelectionLoop = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitSelectionLoop = (vtkImplicitSelectionLoop)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitSelectionLoop.Register(null);
				}
			}
			return vtkImplicitSelectionLoop;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_16(HandleRef pThis, int _arg);

		public virtual void SetAutomaticNormalGeneration(int _arg)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetAutomaticNormalGeneration_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_SetLoop_17(HandleRef pThis, HandleRef arg0);

		public virtual void SetLoop(vtkPoints arg0)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetLoop_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_SetNormal_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetNormal_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSelectionLoop_SetNormal_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetNormal(IntPtr _arg)
		{
			vtkImplicitSelectionLoop.vtkImplicitSelectionLoop_SetNormal_19(base.GetCppThis(), _arg);
		}
	}
}
