using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPPairwiseExtractHistogram2D : vtkPairwiseExtractHistogram2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPPairwiseExtractHistogram2D";

		public new static readonly string MRClassNameKey;

		static vtkPPairwiseExtractHistogram2D()
		{
			vtkPPairwiseExtractHistogram2D.MRClassNameKey = "class vtkPPairwiseExtractHistogram2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPPairwiseExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPPairwiseExtractHistogram2D"));
		}

		public vtkPPairwiseExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPPairwiseExtractHistogram2D New()
		{
			vtkPPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPPairwiseExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPPairwiseExtractHistogram2D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPPairwiseExtractHistogram2D_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPPairwiseExtractHistogram2D NewInstance()
		{
			vtkPPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPPairwiseExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPPairwiseExtractHistogram2D vtkPPairwiseExtractHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPPairwiseExtractHistogram2D = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPPairwiseExtractHistogram2D.Register(null);
				}
			}
			return vtkPPairwiseExtractHistogram2D;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPPairwiseExtractHistogram2D_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
