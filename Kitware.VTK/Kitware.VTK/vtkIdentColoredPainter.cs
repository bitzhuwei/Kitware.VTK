using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIdentColoredPainter : vtkPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdentColoredPainter";

		public new static readonly string MRClassNameKey;

		static vtkIdentColoredPainter()
		{
			vtkIdentColoredPainter.MRClassNameKey = "class vtkIdentColoredPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdentColoredPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdentColoredPainter"));
		}

		public vtkIdentColoredPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentColoredPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdentColoredPainter New()
		{
			vtkIdentColoredPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentColoredPainter.vtkIdentColoredPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentColoredPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIdentColoredPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIdentColoredPainter.vtkIdentColoredPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkIdentColoredPainter_ColorByActorId_01(HandleRef pThis, HandleRef ActorId);

		public void ColorByActorId(vtkProp ActorId)
		{
			vtkIdentColoredPainter.vtkIdentColoredPainter_ColorByActorId_01(base.GetCppThis(), (ActorId == null) ? default(HandleRef) : ActorId.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkIdentColoredPainter_ColorByConstant_02(HandleRef pThis, uint constant);

		public void ColorByConstant(uint constant)
		{
			vtkIdentColoredPainter.vtkIdentColoredPainter_ColorByConstant_02(base.GetCppThis(), constant);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkIdentColoredPainter_ColorByIncreasingIdent_03(HandleRef pThis, uint plane);

		public void ColorByIncreasingIdent(uint plane)
		{
			vtkIdentColoredPainter.vtkIdentColoredPainter_ColorByIncreasingIdent_03(base.GetCppThis(), plane);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkIdentColoredPainter_ColorByVertex_04(HandleRef pThis);

		public void ColorByVertex()
		{
			vtkIdentColoredPainter.vtkIdentColoredPainter_ColorByVertex_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentColoredPainter_GetActorFromId_05(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProp GetActorFromId(long id)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentColoredPainter.vtkIdentColoredPainter_GetActorFromId_05(base.GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkIdentColoredPainter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIdentColoredPainter.vtkIdentColoredPainter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkIdentColoredPainter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIdentColoredPainter.vtkIdentColoredPainter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentColoredPainter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIdentColoredPainter NewInstance()
		{
			vtkIdentColoredPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentColoredPainter.vtkIdentColoredPainter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentColoredPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkIdentColoredPainter_ResetCurrentId_10(HandleRef pThis);

		public void ResetCurrentId()
		{
			vtkIdentColoredPainter.vtkIdentColoredPainter_ResetCurrentId_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentColoredPainter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdentColoredPainter SafeDownCast(vtkObjectBase o)
		{
			vtkIdentColoredPainter vtkIdentColoredPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentColoredPainter.vtkIdentColoredPainter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdentColoredPainter = (vtkIdentColoredPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdentColoredPainter.Register(null);
				}
			}
			return vtkIdentColoredPainter;
		}
	}
}
