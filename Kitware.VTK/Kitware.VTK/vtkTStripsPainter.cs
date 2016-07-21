using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTStripsPainter : vtkPrimitivePainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTStripsPainter";

		public new static readonly string MRClassNameKey;

		static vtkTStripsPainter()
		{
			vtkTStripsPainter.MRClassNameKey = "class vtkTStripsPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTStripsPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTStripsPainter"));
		}

		public vtkTStripsPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTStripsPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTStripsPainter New()
		{
			vtkTStripsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTStripsPainter.vtkTStripsPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTStripsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTStripsPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTStripsPainter.vtkTStripsPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTStripsPainter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTStripsPainter.vtkTStripsPainter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTStripsPainter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTStripsPainter.vtkTStripsPainter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTStripsPainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTStripsPainter NewInstance()
		{
			vtkTStripsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTStripsPainter.vtkTStripsPainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTStripsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTStripsPainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTStripsPainter SafeDownCast(vtkObjectBase o)
		{
			vtkTStripsPainter vtkTStripsPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTStripsPainter.vtkTStripsPainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTStripsPainter = (vtkTStripsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTStripsPainter.Register(null);
				}
			}
			return vtkTStripsPainter;
		}
	}
}
