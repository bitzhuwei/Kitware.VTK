using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGaussianRandomSequence : vtkRandomSequence
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianRandomSequence";

		public new static readonly string MRClassNameKey;

		static vtkGaussianRandomSequence()
		{
			vtkGaussianRandomSequence.MRClassNameKey = "class vtkGaussianRandomSequence";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianRandomSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianRandomSequence"));
		}

		public vtkGaussianRandomSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkGaussianRandomSequence_GetScaledValue_01(HandleRef pThis, double mean, double standardDeviation);

		public virtual double GetScaledValue(double mean, double standardDeviation)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_GetScaledValue_01(base.GetCppThis(), mean, standardDeviation);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGaussianRandomSequence_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGaussianRandomSequence_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGaussianRandomSequence.vtkGaussianRandomSequence_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianRandomSequence_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGaussianRandomSequence NewInstance()
		{
			vtkGaussianRandomSequence result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianRandomSequence.vtkGaussianRandomSequence_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianRandomSequence_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGaussianRandomSequence SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianRandomSequence vtkGaussianRandomSequence = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianRandomSequence.vtkGaussianRandomSequence_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianRandomSequence = (vtkGaussianRandomSequence)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianRandomSequence.Register(null);
				}
			}
			return vtkGaussianRandomSequence;
		}
	}
}
