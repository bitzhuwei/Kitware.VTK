using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSplitColumnComponents : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplitColumnComponents";

		public new static readonly string MRClassNameKey;

		static vtkSplitColumnComponents()
		{
			vtkSplitColumnComponents.MRClassNameKey = "class vtkSplitColumnComponents";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplitColumnComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitColumnComponents"));
		}

		public vtkSplitColumnComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitColumnComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplitColumnComponents New()
		{
			vtkSplitColumnComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSplitColumnComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSplitColumnComponents.vtkSplitColumnComponents_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSplitColumnComponents_GetCalculateMagnitudes_01(HandleRef pThis);

		public virtual bool GetCalculateMagnitudes()
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetCalculateMagnitudes_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSplitColumnComponents_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSplitColumnComponents_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitColumnComponents_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSplitColumnComponents NewInstance()
		{
			vtkSplitColumnComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSplitColumnComponents_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSplitColumnComponents SafeDownCast(vtkObjectBase o)
		{
			vtkSplitColumnComponents vtkSplitColumnComponents = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplitColumnComponents = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplitColumnComponents.Register(null);
				}
			}
			return vtkSplitColumnComponents;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSplitColumnComponents_SetCalculateMagnitudes_07(HandleRef pThis, byte _arg);

		public virtual void SetCalculateMagnitudes(bool _arg)
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetCalculateMagnitudes_07(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
