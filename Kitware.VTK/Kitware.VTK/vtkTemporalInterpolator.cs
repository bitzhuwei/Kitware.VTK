using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalInterpolator : vtkTemporalDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkTemporalInterpolator()
		{
			vtkTemporalInterpolator.MRClassNameKey = "class vtkTemporalInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolator"));
		}

		public vtkTemporalInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalInterpolator New()
		{
			vtkTemporalInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalInterpolator.vtkTemporalInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTemporalInterpolator_GetDiscreteTimeStepInterval_01(HandleRef pThis);

		public virtual double GetDiscreteTimeStepInterval()
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetDiscreteTimeStepInterval_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolator_GetResampleFactor_02(HandleRef pThis);

		public virtual int GetResampleFactor()
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_GetResampleFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalInterpolator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalInterpolator.vtkTemporalInterpolator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalInterpolator NewInstance()
		{
			vtkTemporalInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalInterpolator vtkTemporalInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalInterpolator.vtkTemporalInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalInterpolator = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalInterpolator.Register(null);
				}
			}
			return vtkTemporalInterpolator;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolator_SetDiscreteTimeStepInterval_08(HandleRef pThis, double _arg);

		public virtual void SetDiscreteTimeStepInterval(double _arg)
		{
			vtkTemporalInterpolator.vtkTemporalInterpolator_SetDiscreteTimeStepInterval_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalInterpolator_SetResampleFactor_09(HandleRef pThis, int _arg);

		public virtual void SetResampleFactor(int _arg)
		{
			vtkTemporalInterpolator.vtkTemporalInterpolator_SetResampleFactor_09(base.GetCppThis(), _arg);
		}
	}
}
