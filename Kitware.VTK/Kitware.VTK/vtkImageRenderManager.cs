using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageRenderManager : vtkParallelRenderManager
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRenderManager";

		public new static readonly string MRClassNameKey;

		static vtkImageRenderManager()
		{
			vtkImageRenderManager.MRClassNameKey = "class vtkImageRenderManager";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRenderManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRenderManager"));
		}

		public vtkImageRenderManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRenderManager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRenderManager New()
		{
			vtkImageRenderManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRenderManager.vtkImageRenderManager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageRenderManager() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageRenderManager.vtkImageRenderManager_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkImageRenderManager_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageRenderManager.vtkImageRenderManager_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkImageRenderManager_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageRenderManager.vtkImageRenderManager_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRenderManager_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageRenderManager NewInstance()
		{
			vtkImageRenderManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRenderManager.vtkImageRenderManager_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRenderManager_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRenderManager SafeDownCast(vtkObjectBase o)
		{
			vtkImageRenderManager vtkImageRenderManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRenderManager.vtkImageRenderManager_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRenderManager = (vtkImageRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRenderManager.Register(null);
				}
			}
			return vtkImageRenderManager;
		}
	}
}
