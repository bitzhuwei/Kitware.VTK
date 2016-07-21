using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConvertSelectionDomain : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertSelectionDomain";

		public new static readonly string MRClassNameKey;

		static vtkConvertSelectionDomain()
		{
			vtkConvertSelectionDomain.MRClassNameKey = "class vtkConvertSelectionDomain";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertSelectionDomain.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertSelectionDomain"));
		}

		public vtkConvertSelectionDomain(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelectionDomain_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConvertSelectionDomain New()
		{
			vtkConvertSelectionDomain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConvertSelectionDomain() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConvertSelectionDomain.vtkConvertSelectionDomain_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkConvertSelectionDomain_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkConvertSelectionDomain_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConvertSelectionDomain.vtkConvertSelectionDomain_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelectionDomain_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConvertSelectionDomain NewInstance()
		{
			vtkConvertSelectionDomain result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkConvertSelectionDomain_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConvertSelectionDomain SafeDownCast(vtkObjectBase o)
		{
			vtkConvertSelectionDomain vtkConvertSelectionDomain = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConvertSelectionDomain.vtkConvertSelectionDomain_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertSelectionDomain = (vtkConvertSelectionDomain)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertSelectionDomain.Register(null);
				}
			}
			return vtkConvertSelectionDomain;
		}
	}
}
