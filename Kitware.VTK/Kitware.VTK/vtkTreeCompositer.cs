using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeCompositer : vtkCompositer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeCompositer";

		public new static readonly string MRClassNameKey;

		static vtkTreeCompositer()
		{
			vtkTreeCompositer.MRClassNameKey = "class vtkTreeCompositer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeCompositer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeCompositer"));
		}

		public vtkTreeCompositer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeCompositer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeCompositer New()
		{
			vtkTreeCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeCompositer.vtkTreeCompositer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeCompositer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeCompositer.vtkTreeCompositer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkTreeCompositer_CompositeBuffer_01(HandleRef pThis, HandleRef pBuf, HandleRef zBuf, HandleRef pTmp, HandleRef zTmp);

		public override void CompositeBuffer(vtkDataArray pBuf, vtkFloatArray zBuf, vtkDataArray pTmp, vtkFloatArray zTmp)
		{
			vtkTreeCompositer.vtkTreeCompositer_CompositeBuffer_01(base.GetCppThis(), (pBuf == null) ? default(HandleRef) : pBuf.GetCppThis(), (zBuf == null) ? default(HandleRef) : zBuf.GetCppThis(), (pTmp == null) ? default(HandleRef) : pTmp.GetCppThis(), (zTmp == null) ? default(HandleRef) : zTmp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTreeCompositer_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeCompositer.vtkTreeCompositer_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkTreeCompositer_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeCompositer.vtkTreeCompositer_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeCompositer_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeCompositer NewInstance()
		{
			vtkTreeCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeCompositer.vtkTreeCompositer_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeCompositer_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeCompositer SafeDownCast(vtkObjectBase o)
		{
			vtkTreeCompositer vtkTreeCompositer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeCompositer.vtkTreeCompositer_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeCompositer = (vtkTreeCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeCompositer.Register(null);
				}
			}
			return vtkTreeCompositer;
		}
	}
}
