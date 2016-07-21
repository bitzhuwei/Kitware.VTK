using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPBivariateLinearTableThreshold : vtkBivariateLinearTableThreshold
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPBivariateLinearTableThreshold";

		public new static readonly string MRClassNameKey;

		static vtkPBivariateLinearTableThreshold()
		{
			vtkPBivariateLinearTableThreshold.MRClassNameKey = "class vtkPBivariateLinearTableThreshold";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPBivariateLinearTableThreshold.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBivariateLinearTableThreshold"));
		}

		public vtkPBivariateLinearTableThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPBivariateLinearTableThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPBivariateLinearTableThreshold New()
		{
			vtkPBivariateLinearTableThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPBivariateLinearTableThreshold() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPBivariateLinearTableThreshold_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPBivariateLinearTableThreshold_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPBivariateLinearTableThreshold_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPBivariateLinearTableThreshold_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPBivariateLinearTableThreshold NewInstance()
		{
			vtkPBivariateLinearTableThreshold result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPBivariateLinearTableThreshold_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPBivariateLinearTableThreshold SafeDownCast(vtkObjectBase o)
		{
			vtkPBivariateLinearTableThreshold vtkPBivariateLinearTableThreshold = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPBivariateLinearTableThreshold = (vtkPBivariateLinearTableThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPBivariateLinearTableThreshold.Register(null);
				}
			}
			return vtkPBivariateLinearTableThreshold;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPBivariateLinearTableThreshold_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPBivariateLinearTableThreshold.vtkPBivariateLinearTableThreshold_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
