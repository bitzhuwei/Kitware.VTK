using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedBlock : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedBlock";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedBlock()
		{
			vtkExtractSelectedBlock.MRClassNameKey = "class vtkExtractSelectedBlock";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedBlock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedBlock"));
		}

		public vtkExtractSelectedBlock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedBlock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedBlock New()
		{
			vtkExtractSelectedBlock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedBlock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedBlock.vtkExtractSelectedBlock_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedBlock_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedBlock_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedBlock.vtkExtractSelectedBlock_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedBlock_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedBlock NewInstance()
		{
			vtkExtractSelectedBlock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedBlock_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedBlock SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedBlock vtkExtractSelectedBlock = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedBlock.vtkExtractSelectedBlock_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedBlock = (vtkExtractSelectedBlock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedBlock.Register(null);
				}
			}
			return vtkExtractSelectedBlock;
		}
	}
}
