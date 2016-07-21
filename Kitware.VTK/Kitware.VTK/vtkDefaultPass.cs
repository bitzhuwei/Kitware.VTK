using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDefaultPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDefaultPass";

		public new static readonly string MRClassNameKey;

		static vtkDefaultPass()
		{
			vtkDefaultPass.MRClassNameKey = "class vtkDefaultPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDefaultPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDefaultPass"));
		}

		public vtkDefaultPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDefaultPass New()
		{
			vtkDefaultPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDefaultPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDefaultPass.vtkDefaultPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDefaultPass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDefaultPass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDefaultPass.vtkDefaultPass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDefaultPass NewInstance()
		{
			vtkDefaultPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDefaultPass_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDefaultPass SafeDownCast(vtkObjectBase o)
		{
			vtkDefaultPass vtkDefaultPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDefaultPass.vtkDefaultPass_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDefaultPass = (vtkDefaultPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDefaultPass.Register(null);
				}
			}
			return vtkDefaultPass;
		}
	}
}
