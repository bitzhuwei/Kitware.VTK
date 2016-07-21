using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolygonsPainter : vtkPrimitivePainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonsPainter";

		public new static readonly string MRClassNameKey;

		static vtkPolygonsPainter()
		{
			vtkPolygonsPainter.MRClassNameKey = "class vtkPolygonsPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonsPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonsPainter"));
		}

		public vtkPolygonsPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonsPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonsPainter New()
		{
			vtkPolygonsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonsPainter.vtkPolygonsPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolygonsPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolygonsPainter.vtkPolygonsPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolygonsPainter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolygonsPainter.vtkPolygonsPainter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolygonsPainter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolygonsPainter.vtkPolygonsPainter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonsPainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolygonsPainter NewInstance()
		{
			vtkPolygonsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonsPainter.vtkPolygonsPainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonsPainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonsPainter SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonsPainter vtkPolygonsPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonsPainter.vtkPolygonsPainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonsPainter = (vtkPolygonsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonsPainter.Register(null);
				}
			}
			return vtkPolygonsPainter;
		}
	}
}
