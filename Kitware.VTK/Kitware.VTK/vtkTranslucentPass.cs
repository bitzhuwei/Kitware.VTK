using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTranslucentPass : vtkDefaultPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTranslucentPass";

		public new static readonly string MRClassNameKey;

		static vtkTranslucentPass()
		{
			vtkTranslucentPass.MRClassNameKey = "class vtkTranslucentPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTranslucentPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTranslucentPass"));
		}

		public vtkTranslucentPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTranslucentPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTranslucentPass New()
		{
			vtkTranslucentPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTranslucentPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTranslucentPass.vtkTranslucentPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTranslucentPass_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTranslucentPass_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTranslucentPass.vtkTranslucentPass_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTranslucentPass_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTranslucentPass NewInstance()
		{
			vtkTranslucentPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTranslucentPass_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTranslucentPass SafeDownCast(vtkObjectBase o)
		{
			vtkTranslucentPass vtkTranslucentPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTranslucentPass.vtkTranslucentPass_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTranslucentPass = (vtkTranslucentPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTranslucentPass.Register(null);
				}
			}
			return vtkTranslucentPass;
		}
	}
}
