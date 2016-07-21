using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDataLIC2DExtentTranslator : vtkExtentTranslator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataLIC2DExtentTranslator";

		public new static readonly string MRClassNameKey;

		static vtkImageDataLIC2DExtentTranslator()
		{
			vtkImageDataLIC2DExtentTranslator.MRClassNameKey = "class vtkImageDataLIC2DExtentTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataLIC2DExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataLIC2DExtentTranslator"));
		}

		public vtkImageDataLIC2DExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataLIC2DExtentTranslator New()
		{
			vtkImageDataLIC2DExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2DExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDataLIC2DExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_GetAlgorithm_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageDataLIC2D GetAlgorithm()
		{
			vtkImageDataLIC2D vtkImageDataLIC2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_GetAlgorithm_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataLIC2D = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataLIC2D.Register(null);
				}
			}
			return vtkImageDataLIC2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_GetInputExtentTranslator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkExtentTranslator GetInputExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_GetInputExtentTranslator_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_03(HandleRef pThis);

		public virtual int[] GetInputWholeExtent()
		{
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetInputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetInputWholeExtent(IntPtr _arg)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_GetInputWholeExtent_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2DExtentTranslator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2DExtentTranslator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDataLIC2DExtentTranslator NewInstance()
		{
			vtkImageDataLIC2DExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2DExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2DExtentTranslator_PieceToExtentThreadSafe_10(HandleRef pThis, int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints);

		public override int PieceToExtentThreadSafe(int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints)
		{
			return vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_PieceToExtentThreadSafe_10(base.GetCppThis(), piece, numPieces, ghostLevel, wholeExtent, resultExtent, splitMode, byPoints);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2DExtentTranslator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataLIC2DExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataLIC2DExtentTranslator vtkImageDataLIC2DExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataLIC2DExtentTranslator = (vtkImageDataLIC2DExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataLIC2DExtentTranslator.Register(null);
				}
			}
			return vtkImageDataLIC2DExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_SetAlgorithm_12(HandleRef pThis, HandleRef arg0);

		public void SetAlgorithm(vtkImageDataLIC2D arg0)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_SetAlgorithm_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_SetInputExtentTranslator_13(HandleRef pThis, HandleRef arg0);

		public void SetInputExtentTranslator(vtkExtentTranslator arg0)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_SetInputExtentTranslator_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_SetInputWholeExtent_14(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetInputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_SetInputWholeExtent_14(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2DExtentTranslator_SetInputWholeExtent_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetInputWholeExtent(IntPtr _arg)
		{
			vtkImageDataLIC2DExtentTranslator.vtkImageDataLIC2DExtentTranslator_SetInputWholeExtent_15(base.GetCppThis(), _arg);
		}
	}
}
