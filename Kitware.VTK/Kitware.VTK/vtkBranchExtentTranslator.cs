using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBranchExtentTranslator : vtkExtentTranslator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBranchExtentTranslator";

		public new static readonly string MRClassNameKey;

		static vtkBranchExtentTranslator()
		{
			vtkBranchExtentTranslator.MRClassNameKey = "class vtkBranchExtentTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBranchExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBranchExtentTranslator"));
		}

		public vtkBranchExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkBranchExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBranchExtentTranslator New()
		{
			vtkBranchExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBranchExtentTranslator.vtkBranchExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBranchExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBranchExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBranchExtentTranslator.vtkBranchExtentTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkBranchExtentTranslator_GetAssignedNumberOfPieces_01(HandleRef pThis);

		public virtual int GetAssignedNumberOfPieces()
		{
			return vtkBranchExtentTranslator.vtkBranchExtentTranslator_GetAssignedNumberOfPieces_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkBranchExtentTranslator_GetAssignedPiece_02(HandleRef pThis);

		public virtual int GetAssignedPiece()
		{
			return vtkBranchExtentTranslator.vtkBranchExtentTranslator_GetAssignedPiece_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkBranchExtentTranslator_GetOriginalSource_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetOriginalSource()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBranchExtentTranslator.vtkBranchExtentTranslator_GetOriginalSource_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkBranchExtentTranslator_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBranchExtentTranslator.vtkBranchExtentTranslator_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkBranchExtentTranslator_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBranchExtentTranslator.vtkBranchExtentTranslator_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkBranchExtentTranslator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBranchExtentTranslator NewInstance()
		{
			vtkBranchExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBranchExtentTranslator.vtkBranchExtentTranslator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBranchExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkBranchExtentTranslator_PieceToExtent_08(HandleRef pThis);

		public override int PieceToExtent()
		{
			return vtkBranchExtentTranslator.vtkBranchExtentTranslator_PieceToExtent_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkBranchExtentTranslator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBranchExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkBranchExtentTranslator vtkBranchExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBranchExtentTranslator.vtkBranchExtentTranslator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBranchExtentTranslator = (vtkBranchExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBranchExtentTranslator.Register(null);
				}
			}
			return vtkBranchExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkBranchExtentTranslator_SetAssignedNumberOfPieces_10(HandleRef pThis, int _arg);

		public virtual void SetAssignedNumberOfPieces(int _arg)
		{
			vtkBranchExtentTranslator.vtkBranchExtentTranslator_SetAssignedNumberOfPieces_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkBranchExtentTranslator_SetAssignedPiece_11(HandleRef pThis, int _arg);

		public virtual void SetAssignedPiece(int _arg)
		{
			vtkBranchExtentTranslator.vtkBranchExtentTranslator_SetAssignedPiece_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkBranchExtentTranslator_SetOriginalSource_12(HandleRef pThis, HandleRef arg0);

		public virtual void SetOriginalSource(vtkImageData arg0)
		{
			vtkBranchExtentTranslator.vtkBranchExtentTranslator_SetOriginalSource_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
