using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransferAttributes : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransferAttributes";

		public new static readonly string MRClassNameKey;

		static vtkTransferAttributes()
		{
			vtkTransferAttributes.MRClassNameKey = "class vtkTransferAttributes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransferAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransferAttributes"));
		}

		public vtkTransferAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransferAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransferAttributes New()
		{
			vtkTransferAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransferAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransferAttributes.vtkTransferAttributes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_DirectMappingOff_01(HandleRef pThis);

		public virtual void DirectMappingOff()
		{
			vtkTransferAttributes.vtkTransferAttributes_DirectMappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_DirectMappingOn_02(HandleRef pThis);

		public virtual void DirectMappingOn()
		{
			vtkTransferAttributes.vtkTransferAttributes_DirectMappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransferAttributes_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTransferAttributes.vtkTransferAttributes_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTransferAttributes_GetDirectMapping_04(HandleRef pThis);

		public virtual bool GetDirectMapping()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetDirectMapping_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransferAttributes_GetSourceArrayName_05(HandleRef pThis);

		public virtual string GetSourceArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTransferAttributes.vtkTransferAttributes_GetSourceArrayName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransferAttributes_GetSourceFieldType_06(HandleRef pThis);

		public virtual int GetSourceFieldType()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetSourceFieldType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransferAttributes_GetTargetArrayName_07(HandleRef pThis);

		public virtual string GetTargetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkTransferAttributes.vtkTransferAttributes_GetTargetArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransferAttributes_GetTargetFieldType_08(HandleRef pThis);

		public virtual int GetTargetFieldType()
		{
			return vtkTransferAttributes.vtkTransferAttributes_GetTargetFieldType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransferAttributes_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTransferAttributes_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransferAttributes.vtkTransferAttributes_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransferAttributes_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransferAttributes NewInstance()
		{
			vtkTransferAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTransferAttributes_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransferAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkTransferAttributes vtkTransferAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransferAttributes.vtkTransferAttributes_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransferAttributes = (vtkTransferAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransferAttributes.Register(null);
				}
			}
			return vtkTransferAttributes;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_SetDirectMapping_14(HandleRef pThis, byte _arg);

		public virtual void SetDirectMapping(bool _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetDirectMapping_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_SetSourceArrayName_15(HandleRef pThis, string _arg);

		public virtual void SetSourceArrayName(string _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetSourceArrayName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_SetSourceFieldType_16(HandleRef pThis, int _arg);

		public virtual void SetSourceFieldType(int _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetSourceFieldType_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_SetTargetArrayName_17(HandleRef pThis, string _arg);

		public virtual void SetTargetArrayName(string _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetTargetArrayName_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTransferAttributes_SetTargetFieldType_18(HandleRef pThis, int _arg);

		public virtual void SetTargetFieldType(int _arg)
		{
			vtkTransferAttributes.vtkTransferAttributes_SetTargetFieldType_18(base.GetCppThis(), _arg);
		}
	}
}
