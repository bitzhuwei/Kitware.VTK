using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRepresentationPainter : vtkPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRepresentationPainter";

		public new static readonly string MRClassNameKey;

		static vtkRepresentationPainter()
		{
			vtkRepresentationPainter.MRClassNameKey = "class vtkRepresentationPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRepresentationPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRepresentationPainter"));
		}

		public vtkRepresentationPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRepresentationPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRepresentationPainter New()
		{
			vtkRepresentationPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRepresentationPainter.vtkRepresentationPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRepresentationPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRepresentationPainter.vtkRepresentationPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRepresentationPainter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRepresentationPainter.vtkRepresentationPainter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRepresentationPainter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRepresentationPainter.vtkRepresentationPainter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRepresentationPainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRepresentationPainter NewInstance()
		{
			vtkRepresentationPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRepresentationPainter.vtkRepresentationPainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRepresentationPainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRepresentationPainter SafeDownCast(vtkObjectBase o)
		{
			vtkRepresentationPainter vtkRepresentationPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRepresentationPainter.vtkRepresentationPainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRepresentationPainter = (vtkRepresentationPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRepresentationPainter.Register(null);
				}
			}
			return vtkRepresentationPainter;
		}
	}
}
