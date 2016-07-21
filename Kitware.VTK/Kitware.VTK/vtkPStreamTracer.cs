using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPStreamTracer : vtkStreamTracer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPStreamTracer";

		public new static readonly string MRClassNameKey;

		static vtkPStreamTracer()
		{
			vtkPStreamTracer.MRClassNameKey = "class vtkPStreamTracer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPStreamTracer"));
		}

		public vtkPStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPStreamTracer_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPStreamTracer.vtkPStreamTracer_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPStreamTracer_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPStreamTracer.vtkPStreamTracer_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPStreamTracer_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPStreamTracer.vtkPStreamTracer_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPStreamTracer_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPStreamTracer NewInstance()
		{
			vtkPStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPStreamTracer.vtkPStreamTracer_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPStreamTracer_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkPStreamTracer vtkPStreamTracer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPStreamTracer.vtkPStreamTracer_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPStreamTracer = (vtkPStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPStreamTracer.Register(null);
				}
			}
			return vtkPStreamTracer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPStreamTracer_SetController_06(HandleRef pThis, HandleRef controller);

		public virtual void SetController(vtkMultiProcessController controller)
		{
			vtkPStreamTracer.vtkPStreamTracer_SetController_06(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}
	}
}
