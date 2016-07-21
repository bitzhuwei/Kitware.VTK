using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpaquePass : vtkDefaultPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpaquePass";

		public new static readonly string MRClassNameKey;

		static vtkOpaquePass()
		{
			vtkOpaquePass.MRClassNameKey = "class vtkOpaquePass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpaquePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpaquePass"));
		}

		public vtkOpaquePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpaquePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpaquePass New()
		{
			vtkOpaquePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpaquePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpaquePass.vtkOpaquePass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpaquePass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpaquePass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpaquePass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpaquePass NewInstance()
		{
			vtkOpaquePass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpaquePass_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpaquePass SafeDownCast(vtkObjectBase o)
		{
			vtkOpaquePass vtkOpaquePass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpaquePass = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpaquePass.Register(null);
				}
			}
			return vtkOpaquePass;
		}
	}
}
