using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClipPlanesPainter : vtkPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipPlanesPainter";

		public new static readonly string MRClassNameKey;

		static vtkClipPlanesPainter()
		{
			vtkClipPlanesPainter.MRClassNameKey = "class vtkClipPlanesPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipPlanesPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipPlanesPainter"));
		}

		public vtkClipPlanesPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPlanesPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipPlanesPainter New()
		{
			vtkClipPlanesPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPlanesPainter.vtkClipPlanesPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClipPlanesPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClipPlanesPainter.vtkClipPlanesPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPlanesPainter_CLIPPING_PLANES_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey CLIPPING_PLANES()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPlanesPainter.vtkClipPlanesPainter_CLIPPING_PLANES_01(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkClipPlanesPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClipPlanesPainter.vtkClipPlanesPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkClipPlanesPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClipPlanesPainter.vtkClipPlanesPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPlanesPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClipPlanesPainter NewInstance()
		{
			vtkClipPlanesPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPlanesPainter.vtkClipPlanesPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClipPlanesPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClipPlanesPainter SafeDownCast(vtkObjectBase o)
		{
			vtkClipPlanesPainter vtkClipPlanesPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClipPlanesPainter.vtkClipPlanesPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipPlanesPainter = (vtkClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipPlanesPainter.Register(null);
				}
			}
			return vtkClipPlanesPainter;
		}
	}
}
