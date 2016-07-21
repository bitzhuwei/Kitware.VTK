using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPrimitivePainter : vtkPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPrimitivePainter";

		public new static readonly string MRClassNameKey;

		static vtkPrimitivePainter()
		{
			vtkPrimitivePainter.MRClassNameKey = "class vtkPrimitivePainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPrimitivePainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPrimitivePainter"));
		}

		public vtkPrimitivePainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPrimitivePainter_GetSupportedPrimitive_01(HandleRef pThis);

		public virtual int GetSupportedPrimitive()
		{
			return vtkPrimitivePainter.vtkPrimitivePainter_GetSupportedPrimitive_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPrimitivePainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPrimitivePainter.vtkPrimitivePainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPrimitivePainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPrimitivePainter.vtkPrimitivePainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPrimitivePainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPrimitivePainter NewInstance()
		{
			vtkPrimitivePainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPrimitivePainter.vtkPrimitivePainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPrimitivePainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPrimitivePainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPrimitivePainter SafeDownCast(vtkObjectBase o)
		{
			vtkPrimitivePainter vtkPrimitivePainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPrimitivePainter.vtkPrimitivePainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPrimitivePainter = (vtkPrimitivePainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPrimitivePainter.Register(null);
				}
			}
			return vtkPrimitivePainter;
		}
	}
}
