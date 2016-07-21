using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOverlayPass : vtkDefaultPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverlayPass";

		public new static readonly string MRClassNameKey;

		static vtkOverlayPass()
		{
			vtkOverlayPass.MRClassNameKey = "class vtkOverlayPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverlayPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlayPass"));
		}

		public vtkOverlayPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOverlayPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverlayPass New()
		{
			vtkOverlayPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOverlayPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOverlayPass.vtkOverlayPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOverlayPass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOverlayPass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOverlayPass.vtkOverlayPass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOverlayPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOverlayPass NewInstance()
		{
			vtkOverlayPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOverlayPass_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOverlayPass SafeDownCast(vtkObjectBase o)
		{
			vtkOverlayPass vtkOverlayPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOverlayPass.vtkOverlayPass_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlayPass = (vtkOverlayPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlayPass.Register(null);
				}
			}
			return vtkOverlayPass;
		}
	}
}
