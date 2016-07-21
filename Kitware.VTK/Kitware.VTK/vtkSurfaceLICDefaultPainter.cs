using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSurfaceLICDefaultPainter : vtkDefaultPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceLICDefaultPainter";

		public new static readonly string MRClassNameKey;

		static vtkSurfaceLICDefaultPainter()
		{
			vtkSurfaceLICDefaultPainter.MRClassNameKey = "class vtkSurfaceLICDefaultPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceLICDefaultPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceLICDefaultPainter"));
		}

		public vtkSurfaceLICDefaultPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICDefaultPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceLICDefaultPainter New()
		{
			vtkSurfaceLICDefaultPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSurfaceLICDefaultPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICDefaultPainter_GetSurfaceLICPainter_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSurfaceLICPainter GetSurfaceLICPainter()
		{
			vtkSurfaceLICPainter vtkSurfaceLICPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_GetSurfaceLICPainter_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceLICPainter = (vtkSurfaceLICPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceLICPainter.Register(null);
				}
			}
			return vtkSurfaceLICPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICDefaultPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICDefaultPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICDefaultPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSurfaceLICDefaultPainter NewInstance()
		{
			vtkSurfaceLICDefaultPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICDefaultPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceLICDefaultPainter SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceLICDefaultPainter vtkSurfaceLICDefaultPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceLICDefaultPainter = (vtkSurfaceLICDefaultPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceLICDefaultPainter.Register(null);
				}
			}
			return vtkSurfaceLICDefaultPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICDefaultPainter_SetSurfaceLICPainter_07(HandleRef pThis, HandleRef arg0);

		public void SetSurfaceLICPainter(vtkSurfaceLICPainter arg0)
		{
			vtkSurfaceLICDefaultPainter.vtkSurfaceLICDefaultPainter_SetSurfaceLICPainter_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
