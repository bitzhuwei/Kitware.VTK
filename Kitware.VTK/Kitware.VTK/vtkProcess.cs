using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkProcess : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcess";

		public new static readonly string MRClassNameKey;

		static vtkProcess()
		{
			vtkProcess.MRClassNameKey = "class vtkProcess";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcess.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcess"));
		}

		public vtkProcess(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcess_Execute_01(HandleRef pThis);

		public virtual void Execute()
		{
			vtkProcess.vtkProcess_Execute_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcess_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcess.vtkProcess_GetController_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkProcess_GetReturnValue_03(HandleRef pThis);

		public int GetReturnValue()
		{
			return vtkProcess.vtkProcess_GetReturnValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcess_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProcess.vtkProcess_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkProcess_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProcess.vtkProcess_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcess_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProcess NewInstance()
		{
			vtkProcess result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcess.vtkProcess_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcess)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkProcess_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProcess SafeDownCast(vtkObjectBase o)
		{
			vtkProcess vtkProcess = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProcess.vtkProcess_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcess = (vtkProcess)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcess.Register(null);
				}
			}
			return vtkProcess;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkProcess_SetController_08(HandleRef pThis, HandleRef aController);

		public void SetController(vtkMultiProcessController aController)
		{
			vtkProcess.vtkProcess_SetController_08(base.GetCppThis(), (aController == null) ? default(HandleRef) : aController.GetCppThis());
		}
	}
}
