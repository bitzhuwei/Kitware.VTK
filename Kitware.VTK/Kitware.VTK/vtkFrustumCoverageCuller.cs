using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFrustumCoverageCuller : vtkCuller
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumCoverageCuller";

		public new static readonly string MRClassNameKey;

		static vtkFrustumCoverageCuller()
		{
			vtkFrustumCoverageCuller.MRClassNameKey = "class vtkFrustumCoverageCuller";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrustumCoverageCuller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumCoverageCuller"));
		}

		public vtkFrustumCoverageCuller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumCoverageCuller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrustumCoverageCuller New()
		{
			vtkFrustumCoverageCuller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFrustumCoverageCuller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkFrustumCoverageCuller_GetMaximumCoverage_01(HandleRef pThis);

		public virtual double GetMaximumCoverage()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetMaximumCoverage_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkFrustumCoverageCuller_GetMinimumCoverage_02(HandleRef pThis);

		public virtual double GetMinimumCoverage()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetMinimumCoverage_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyle_03(HandleRef pThis);

		public virtual int GetSortingStyle()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyle_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumCoverageCuller_GetSortingStyleAsString_04(HandleRef pThis);

		public string GetSortingStyleAsString()
		{
			return Marshal.PtrToStringAnsi(vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleAsString_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMaxValue_05(HandleRef pThis);

		public virtual int GetSortingStyleMaxValue()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrustumCoverageCuller_GetSortingStyleMinValue_06(HandleRef pThis);

		public virtual int GetSortingStyleMinValue()
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_GetSortingStyleMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrustumCoverageCuller_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrustumCoverageCuller_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumCoverageCuller_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFrustumCoverageCuller NewInstance()
		{
			vtkFrustumCoverageCuller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrustumCoverageCuller_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrustumCoverageCuller SafeDownCast(vtkObjectBase o)
		{
			vtkFrustumCoverageCuller vtkFrustumCoverageCuller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrustumCoverageCuller = (vtkFrustumCoverageCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrustumCoverageCuller.Register(null);
				}
			}
			return vtkFrustumCoverageCuller;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetMaximumCoverage_12(HandleRef pThis, double _arg);

		public virtual void SetMaximumCoverage(double _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetMaximumCoverage_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetMinimumCoverage_13(HandleRef pThis, double _arg);

		public virtual void SetMinimumCoverage(double _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetMinimumCoverage_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyle_14(HandleRef pThis, int _arg);

		public virtual void SetSortingStyle(int _arg)
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyle_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_15(HandleRef pThis);

		public void SetSortingStyleToBackToFront()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToBackToFront_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_16(HandleRef pThis);

		public void SetSortingStyleToFrontToBack()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToFrontToBack_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrustumCoverageCuller_SetSortingStyleToNone_17(HandleRef pThis);

		public void SetSortingStyleToNone()
		{
			vtkFrustumCoverageCuller.vtkFrustumCoverageCuller_SetSortingStyleToNone_17(base.GetCppThis());
		}
	}
}
