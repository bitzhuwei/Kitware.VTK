using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPComputeHistogram2DOutliers : vtkComputeHistogram2DOutliers
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPComputeHistogram2DOutliers";

		public new static readonly string MRClassNameKey;

		static vtkPComputeHistogram2DOutliers()
		{
			vtkPComputeHistogram2DOutliers.MRClassNameKey = "class vtkPComputeHistogram2DOutliers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPComputeHistogram2DOutliers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPComputeHistogram2DOutliers"));
		}

		public vtkPComputeHistogram2DOutliers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPComputeHistogram2DOutliers New()
		{
			vtkPComputeHistogram2DOutliers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPComputeHistogram2DOutliers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPComputeHistogram2DOutliers_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPComputeHistogram2DOutliers_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPComputeHistogram2DOutliers NewInstance()
		{
			vtkPComputeHistogram2DOutliers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPComputeHistogram2DOutliers_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPComputeHistogram2DOutliers SafeDownCast(vtkObjectBase o)
		{
			vtkPComputeHistogram2DOutliers vtkPComputeHistogram2DOutliers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPComputeHistogram2DOutliers = (vtkPComputeHistogram2DOutliers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPComputeHistogram2DOutliers.Register(null);
				}
			}
			return vtkPComputeHistogram2DOutliers;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPComputeHistogram2DOutliers_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPComputeHistogram2DOutliers.vtkPComputeHistogram2DOutliers_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
