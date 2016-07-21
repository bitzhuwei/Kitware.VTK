using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositer : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositer";

		public new static readonly string MRClassNameKey;

		static vtkCompositer()
		{
			vtkCompositer.MRClassNameKey = "class vtkCompositer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositer"));
		}

		public vtkCompositer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositer New()
		{
			vtkCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositer.vtkCompositer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositer.vtkCompositer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_CompositeBuffer_01(HandleRef pThis, HandleRef pBuf, HandleRef zBuf, HandleRef pTmp, HandleRef zTmp);

		public virtual void CompositeBuffer(vtkDataArray pBuf, vtkFloatArray zBuf, vtkDataArray pTmp, vtkFloatArray zTmp)
		{
			vtkCompositer.vtkCompositer_CompositeBuffer_01(base.GetCppThis(), (pBuf == null) ? default(HandleRef) : pBuf.GetCppThis(), (zBuf == null) ? default(HandleRef) : zBuf.GetCppThis(), (pTmp == null) ? default(HandleRef) : pTmp.GetCppThis(), (zTmp == null) ? default(HandleRef) : zTmp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_DeleteArray_02(HandleRef da);

		public static void DeleteArray(vtkDataArray da)
		{
			vtkCompositer.vtkCompositer_DeleteArray_02((da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositer_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositer.vtkCompositer_GetController_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkCompositer_GetNumberOfProcesses_04(HandleRef pThis);

		public virtual int GetNumberOfProcesses()
		{
			return vtkCompositer.vtkCompositer_GetNumberOfProcesses_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositer_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositer.vtkCompositer_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompositer_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositer.vtkCompositer_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositer_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositer NewInstance()
		{
			vtkCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositer.vtkCompositer_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_ResizeFloatArray_09(HandleRef fa, int numComp, long size);

		public static void ResizeFloatArray(vtkFloatArray fa, int numComp, long size)
		{
			vtkCompositer.vtkCompositer_ResizeFloatArray_09((fa == null) ? default(HandleRef) : fa.GetCppThis(), numComp, size);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_ResizeUnsignedCharArray_10(HandleRef uca, int numComp, long size);

		public static void ResizeUnsignedCharArray(vtkUnsignedCharArray uca, int numComp, long size)
		{
			vtkCompositer.vtkCompositer_ResizeUnsignedCharArray_10((uca == null) ? default(HandleRef) : uca.GetCppThis(), numComp, size);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositer SafeDownCast(vtkObjectBase o)
		{
			vtkCompositer vtkCompositer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositer.vtkCompositer_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositer = (vtkCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositer.Register(null);
				}
			}
			return vtkCompositer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_SetController_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkCompositer.vtkCompositer_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompositer_SetNumberOfProcesses_13(HandleRef pThis, int _arg);

		public virtual void SetNumberOfProcesses(int _arg)
		{
			vtkCompositer.vtkCompositer_SetNumberOfProcesses_13(base.GetCppThis(), _arg);
		}
	}
}
