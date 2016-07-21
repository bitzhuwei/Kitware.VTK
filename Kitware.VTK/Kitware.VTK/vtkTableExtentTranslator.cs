using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableExtentTranslator : vtkExtentTranslator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableExtentTranslator";

		public new static readonly string MRClassNameKey;

		static vtkTableExtentTranslator()
		{
			vtkTableExtentTranslator.MRClassNameKey = "class vtkTableExtentTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableExtentTranslator"));
		}

		public vtkTableExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTableExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableExtentTranslator New()
		{
			vtkTableExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableExtentTranslator.vtkTableExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableExtentTranslator.vtkTableExtentTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_GetExtentForPiece_01(HandleRef pThis, int piece, IntPtr extent);

		public virtual void GetExtentForPiece(int piece, IntPtr extent)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_GetExtentForPiece_01(base.GetCppThis(), piece, extent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTableExtentTranslator_GetExtentForPiece_02(HandleRef pThis, int piece);

		public virtual IntPtr GetExtentForPiece(int piece)
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_GetExtentForPiece_02(base.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_GetMaximumGhostLevel_03(HandleRef pThis);

		public virtual int GetMaximumGhostLevel()
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_GetMaximumGhostLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_GetNumberOfPiecesInTable_04(HandleRef pThis);

		public virtual int GetNumberOfPiecesInTable()
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_GetNumberOfPiecesInTable_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_GetPieceAvailable_05(HandleRef pThis, int piece);

		public virtual int GetPieceAvailable(int piece)
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_GetPieceAvailable_05(base.GetCppThis(), piece);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTableExtentTranslator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableExtentTranslator NewInstance()
		{
			vtkTableExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableExtentTranslator.vtkTableExtentTranslator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_PieceToExtent_10(HandleRef pThis);

		public override int PieceToExtent()
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_PieceToExtent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_PieceToExtentByPoints_11(HandleRef pThis);

		public override int PieceToExtentByPoints()
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_PieceToExtentByPoints_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTableExtentTranslator_PieceToExtentThreadSafe_12(HandleRef pThis, int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints);

		public override int PieceToExtentThreadSafe(int piece, int numPieces, int ghostLevel, IntPtr wholeExtent, IntPtr resultExtent, int splitMode, int byPoints)
		{
			return vtkTableExtentTranslator.vtkTableExtentTranslator_PieceToExtentThreadSafe_12(base.GetCppThis(), piece, numPieces, ghostLevel, wholeExtent, resultExtent, splitMode, byPoints);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTableExtentTranslator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkTableExtentTranslator vtkTableExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableExtentTranslator.vtkTableExtentTranslator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableExtentTranslator = (vtkTableExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableExtentTranslator.Register(null);
				}
			}
			return vtkTableExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_SetExtentForPiece_14(HandleRef pThis, int piece, IntPtr extent);

		public virtual void SetExtentForPiece(int piece, IntPtr extent)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_SetExtentForPiece_14(base.GetCppThis(), piece, extent);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_SetMaximumGhostLevel_15(HandleRef pThis, int _arg);

		public virtual void SetMaximumGhostLevel(int _arg)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_SetMaximumGhostLevel_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_SetNumberOfPieces_16(HandleRef pThis, int pieces);

		public override void SetNumberOfPieces(int pieces)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_SetNumberOfPieces_16(base.GetCppThis(), pieces);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_SetNumberOfPiecesInTable_17(HandleRef pThis, int pieces);

		public void SetNumberOfPiecesInTable(int pieces)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_SetNumberOfPiecesInTable_17(base.GetCppThis(), pieces);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTableExtentTranslator_SetPieceAvailable_18(HandleRef pThis, int piece, int available);

		public virtual void SetPieceAvailable(int piece, int available)
		{
			vtkTableExtentTranslator.vtkTableExtentTranslator_SetPieceAvailable_18(base.GetCppThis(), piece, available);
		}
	}
}
