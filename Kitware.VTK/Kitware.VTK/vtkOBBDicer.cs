using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOBBDicer : vtkDicer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBBDicer";

		public new static readonly string MRClassNameKey;

		static vtkOBBDicer()
		{
			vtkOBBDicer.MRClassNameKey = "class vtkOBBDicer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBBDicer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBBDicer"));
		}

		public vtkOBBDicer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBDicer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOBBDicer New()
		{
			vtkOBBDicer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOBBDicer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOBBDicer.vtkOBBDicer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBDicer_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBDicer_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBDicer_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOBBDicer NewInstance()
		{
			vtkOBBDicer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBDicer_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOBBDicer SafeDownCast(vtkObjectBase o)
		{
			vtkOBBDicer vtkOBBDicer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBBDicer = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBBDicer.Register(null);
				}
			}
			return vtkOBBDicer;
		}
	}
}
