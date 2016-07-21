using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOnePieceExtentTranslator : vtkExtentTranslator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOnePieceExtentTranslator";

		public new static readonly string MRClassNameKey;

		static vtkOnePieceExtentTranslator()
		{
			vtkOnePieceExtentTranslator.MRClassNameKey = "class vtkOnePieceExtentTranslator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOnePieceExtentTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOnePieceExtentTranslator"));
		}

		public vtkOnePieceExtentTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOnePieceExtentTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOnePieceExtentTranslator New()
		{
			vtkOnePieceExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOnePieceExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOnePieceExtentTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOnePieceExtentTranslator_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkOnePieceExtentTranslator_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOnePieceExtentTranslator_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOnePieceExtentTranslator NewInstance()
		{
			vtkOnePieceExtentTranslator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOnePieceExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkOnePieceExtentTranslator_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOnePieceExtentTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkOnePieceExtentTranslator vtkOnePieceExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOnePieceExtentTranslator.vtkOnePieceExtentTranslator_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOnePieceExtentTranslator = (vtkOnePieceExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOnePieceExtentTranslator.Register(null);
				}
			}
			return vtkOnePieceExtentTranslator;
		}
	}
}
