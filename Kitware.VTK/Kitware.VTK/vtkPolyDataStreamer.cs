using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataStreamer : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataStreamer";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataStreamer()
		{
			vtkPolyDataStreamer.MRClassNameKey = "class vtkPolyDataStreamer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataStreamer"));
		}

		public vtkPolyDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataStreamer New()
		{
			vtkPolyDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataStreamer.vtkPolyDataStreamer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataStreamer_ColorByPieceOff_01(HandleRef pThis);

		public virtual void ColorByPieceOff()
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_ColorByPieceOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataStreamer_ColorByPieceOn_02(HandleRef pThis);

		public virtual void ColorByPieceOn()
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_ColorByPieceOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataStreamer_GetColorByPiece_03(HandleRef pThis);

		public virtual int GetColorByPiece()
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetColorByPiece_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataStreamer_GetNumberOfStreamDivisions_04(HandleRef pThis);

		public virtual int GetNumberOfStreamDivisions()
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetNumberOfStreamDivisions_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataStreamer_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataStreamer_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataStreamer_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataStreamer NewInstance()
		{
			vtkPolyDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataStreamer_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataStreamer vtkPolyDataStreamer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataStreamer = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataStreamer.Register(null);
				}
			}
			return vtkPolyDataStreamer;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataStreamer_SetColorByPiece_10(HandleRef pThis, int _arg);

		public virtual void SetColorByPiece(int _arg)
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_SetColorByPiece_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataStreamer_SetNumberOfStreamDivisions_11(HandleRef pThis, int num);

		public void SetNumberOfStreamDivisions(int num)
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_SetNumberOfStreamDivisions_11(base.GetCppThis(), num);
		}
	}
}
