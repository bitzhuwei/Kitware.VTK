using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformation : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformation";

		public new static readonly string MRClassNameKey;

		static vtkInformation()
		{
			vtkInformation.MRClassNameKey = "class vtkInformation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformation"));
		}

		public vtkInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformation New()
		{
			vtkInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInformation.vtkInformation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Register_102(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkInformation.vtkInformation_Register_102(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_UnRegister_140(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkInformation.vtkInformation_UnRegister_140(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_01(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
		{
			vtkInformation.vtkInformation_Append_01(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_02(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
		{
			vtkInformation.vtkInformation_Append_02(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_03(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
		{
			vtkInformation.vtkInformation_Append_03(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_04(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
		{
			vtkInformation.vtkInformation_Append_04(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_05(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
		{
			vtkInformation.vtkInformation_Append_05(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_06(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
		{
			vtkInformation.vtkInformation_Append_06(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_07(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
		{
			vtkInformation.vtkInformation_Append_07(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_08(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
		{
			vtkInformation.vtkInformation_Append_08(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_09(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
		{
			vtkInformation.vtkInformation_Append_09(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_10(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
		{
			vtkInformation.vtkInformation_Append_10(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_11(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
		{
			vtkInformation.vtkInformation_Append_11(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_12(HandleRef pThis, HandleRef key, int value);

		public void Append(vtkInformationIntegerVectorKey key, int value)
		{
			vtkInformation.vtkInformation_Append_12(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_13(HandleRef pThis, HandleRef key, string value);

		public void Append(vtkInformationStringVectorKey key, string value)
		{
			vtkInformation.vtkInformation_Append_13(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_14(HandleRef pThis, HandleRef key, double value);

		public void Append(vtkInformationDoubleVectorKey key, double value)
		{
			vtkInformation.vtkInformation_Append_14(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Append_15(HandleRef pThis, HandleRef key, HandleRef value);

		public void Append(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_Append_15(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_16(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_16(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_17(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_17(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_18(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_18(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_19(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_19(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_20(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_20(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_21(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_21(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_22(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_22(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_23(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_23(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_24(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_24(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_25(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_25(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_26(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_26(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_AppendUnique_27(HandleRef pThis, HandleRef key, HandleRef value);

		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_27(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Clear_28(HandleRef pThis);

		public void Clear()
		{
			vtkInformation.vtkInformation_Clear_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Copy_29(HandleRef pThis, HandleRef from, int deep);

		public void Copy(vtkInformation from, int deep)
		{
			vtkInformation.vtkInformation_Copy_29(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntries_30(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntries(vtkInformation from, vtkInformationKeyVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntries_30(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_31(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_31(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_32(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationDataObjectKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_32(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_33(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationDoubleVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_33(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_34(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationInformationKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_34(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_35(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationInformationVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_35(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_36(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationIntegerKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_36(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_37(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationIntegerVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_37(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_38(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationRequestKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_38(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_39(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationStringKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_39(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_40(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationStringVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_40(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_CopyEntry_41(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		public void CopyEntry(vtkInformation from, vtkInformationUnsignedLongKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_41(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_42(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationKey Get(vtkInformationKeyVectorKey key, int idx)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_42(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_43(HandleRef pThis, HandleRef key);

		public string Get(vtkInformationStringKey key)
		{
			return Marshal.PtrToStringAnsi(vtkInformation.vtkInformation_Get_43(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_44(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation Get(vtkInformationInformationKey key)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_44(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_45(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationVector Get(vtkInformationInformationVectorKey key)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_45(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_46(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObjectBase Get(vtkInformationObjectBaseKey key)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_46(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_47(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject Get(vtkInformationDataObjectKey key)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_47(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Get_48(HandleRef pThis, HandleRef key);

		public int Get(vtkInformationIntegerKey key)
		{
			return vtkInformation.vtkInformation_Get_48(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkInformation_Get_49(HandleRef pThis, HandleRef key);

		public long Get(vtkInformationIdTypeKey key)
		{
			return vtkInformation.vtkInformation_Get_49(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkInformation_Get_50(HandleRef pThis, HandleRef key);

		public double Get(vtkInformationDoubleKey key)
		{
			return vtkInformation.vtkInformation_Get_50(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_51(HandleRef pThis, HandleRef key);

		public IntPtr Get(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Get_51(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Get_52(HandleRef pThis, HandleRef key, int idx);

		public int Get(vtkInformationIntegerVectorKey key, int idx)
		{
			return vtkInformation.vtkInformation_Get_52(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Get_53(HandleRef pThis, HandleRef key, IntPtr value);

		public void Get(vtkInformationIntegerVectorKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_53(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_54(HandleRef pThis, HandleRef key, int idx);

		public string Get(vtkInformationStringVectorKey key, int idx)
		{
			return Marshal.PtrToStringAnsi(vtkInformation.vtkInformation_Get_54(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_55(HandleRef pThis, HandleRef key);

		public IntPtr Get(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Get_55(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Get_56(HandleRef pThis, HandleRef key, IntPtr value);

		public void Get(vtkInformationIntegerPointerKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_56(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkInformation_Get_57(HandleRef pThis, HandleRef key);

		public uint Get(vtkInformationUnsignedLongKey key)
		{
			return vtkInformation.vtkInformation_Get_57(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_Get_58(HandleRef pThis, HandleRef key);

		public IntPtr Get(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Get_58(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkInformation_Get_59(HandleRef pThis, HandleRef key, int idx);

		public double Get(vtkInformationDoubleVectorKey key, int idx)
		{
			return vtkInformation.vtkInformation_Get_59(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Get_60(HandleRef pThis, HandleRef key, IntPtr value);

		public void Get(vtkInformationDoubleVectorKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_60(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_61(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationDataObjectKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_61((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_62(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationDoubleKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_62((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_63(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationDoubleVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_63((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_64(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationInformationKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_64((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_65(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationInformationVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_65((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_66(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationIntegerKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_66((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_67(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationIntegerVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_67((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_68(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationRequestKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_68((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_69(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationStringKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_69((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_70(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationStringVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_70((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_71(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_71((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetKey_72(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationKey GetKey(vtkInformationUnsignedLongKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_72((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_GetNumberOfKeys_73(HandleRef pThis);

		public int GetNumberOfKeys()
		{
			return vtkInformation.vtkInformation_GetNumberOfKeys_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_GetRequest_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformationRequestKey GetRequest()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_GetRequest_74(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_75(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationKeyVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_75(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_76(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationStringKey key)
		{
			return vtkInformation.vtkInformation_Has_76(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_77(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationInformationKey key)
		{
			return vtkInformation.vtkInformation_Has_77(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_78(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationInformationVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_78(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_79(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationObjectBaseKey key)
		{
			return vtkInformation.vtkInformation_Has_79(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_80(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationDataObjectKey key)
		{
			return vtkInformation.vtkInformation_Has_80(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_81(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationKey key)
		{
			return vtkInformation.vtkInformation_Has_81(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_82(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationRequestKey key)
		{
			return vtkInformation.vtkInformation_Has_82(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_83(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationIntegerKey key)
		{
			return vtkInformation.vtkInformation_Has_83(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_84(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationIdTypeKey key)
		{
			return vtkInformation.vtkInformation_Has_84(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_85(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationDoubleKey key)
		{
			return vtkInformation.vtkInformation_Has_85(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_86(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_86(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_87(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationStringVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_87(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_88(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Has_88(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_89(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationUnsignedLongKey key)
		{
			return vtkInformation.vtkInformation_Has_89(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Has_90(HandleRef pThis, HandleRef key);

		public int Has(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_90(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_IsA_91(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformation.vtkInformation_IsA_91(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_IsTypeOf_92(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformation.vtkInformation_IsTypeOf_92(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Length_93(HandleRef pThis, HandleRef key);

		public int Length(vtkInformationKeyVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_93(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Length_94(HandleRef pThis, HandleRef key);

		public int Length(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_94(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Length_95(HandleRef pThis, HandleRef key);

		public int Length(vtkInformationStringVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_95(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Length_96(HandleRef pThis, HandleRef key);

		public int Length(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Length_96(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformation_Length_97(HandleRef pThis, HandleRef key);

		public int Length(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_97(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Modified_98(HandleRef pThis);

		public override void Modified()
		{
			vtkInformation.vtkInformation_Modified_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Modified_99(HandleRef pThis, HandleRef key);

		public void Modified(vtkInformationKey key)
		{
			vtkInformation.vtkInformation_Modified_99(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_NewInstance_101(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformation NewInstance()
		{
			vtkInformation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_NewInstance_101(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_103(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationKeyVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_103(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_104(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationStringKey key)
		{
			vtkInformation.vtkInformation_Remove_104(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_105(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationInformationKey key)
		{
			vtkInformation.vtkInformation_Remove_105(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_106(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationInformationVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_106(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_107(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationObjectBaseKey key)
		{
			vtkInformation.vtkInformation_Remove_107(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_108(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationDataObjectKey key)
		{
			vtkInformation.vtkInformation_Remove_108(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_109(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationKey key)
		{
			vtkInformation.vtkInformation_Remove_109(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_110(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationRequestKey key)
		{
			vtkInformation.vtkInformation_Remove_110(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_111(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationIntegerKey key)
		{
			vtkInformation.vtkInformation_Remove_111(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_112(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationIdTypeKey key)
		{
			vtkInformation.vtkInformation_Remove_112(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_113(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationDoubleKey key)
		{
			vtkInformation.vtkInformation_Remove_113(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_114(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationIntegerVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_114(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_115(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationStringVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_115(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_116(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationIntegerPointerKey key)
		{
			vtkInformation.vtkInformation_Remove_116(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_117(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationUnsignedLongKey key)
		{
			vtkInformation.vtkInformation_Remove_117(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_118(HandleRef pThis, HandleRef key);

		public void Remove(vtkInformationDoubleVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_118(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Remove_119(HandleRef pThis, HandleRef key, HandleRef value);

		public void Remove(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_Remove_119(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformation_SafeDownCast_120(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformation SafeDownCast(vtkObjectBase o)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformation.vtkInformation_SafeDownCast_120((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_121(HandleRef pThis, HandleRef key, string arg1);

		public void Set(vtkInformationStringKey key, string arg1)
		{
			vtkInformation.vtkInformation_Set_121(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_122(HandleRef pThis, HandleRef key, HandleRef arg1);

		public void Set(vtkInformationInformationKey key, vtkInformation arg1)
		{
			vtkInformation.vtkInformation_Set_122(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_123(HandleRef pThis, HandleRef key, HandleRef arg1);

		public void Set(vtkInformationInformationVectorKey key, vtkInformationVector arg1)
		{
			vtkInformation.vtkInformation_Set_123(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_124(HandleRef pThis, HandleRef key, HandleRef arg1);

		public void Set(vtkInformationObjectBaseKey key, vtkObjectBase arg1)
		{
			vtkInformation.vtkInformation_Set_124(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_125(HandleRef pThis, HandleRef key, HandleRef arg1);

		public void Set(vtkInformationDataObjectKey key, vtkDataObject arg1)
		{
			vtkInformation.vtkInformation_Set_125(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_126(HandleRef pThis, HandleRef key);

		public void Set(vtkInformationRequestKey key)
		{
			vtkInformation.vtkInformation_Set_126(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_127(HandleRef pThis, HandleRef key, int value);

		public void Set(vtkInformationIntegerKey key, int value)
		{
			vtkInformation.vtkInformation_Set_127(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_128(HandleRef pThis, HandleRef key, long value);

		public void Set(vtkInformationIdTypeKey key, long value)
		{
			vtkInformation.vtkInformation_Set_128(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_129(HandleRef pThis, HandleRef key, double value);

		public void Set(vtkInformationDoubleKey key, double value)
		{
			vtkInformation.vtkInformation_Set_129(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_130(HandleRef pThis, HandleRef key, IntPtr value, int length);

		public void Set(vtkInformationIntegerVectorKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_130(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_131(HandleRef pThis, HandleRef key, int value1, int value2, int value3);

		public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3)
		{
			vtkInformation.vtkInformation_Set_131(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_132(HandleRef pThis, HandleRef key, int value1, int value2, int value3, int value4, int value5, int value6);

		public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3, int value4, int value5, int value6)
		{
			vtkInformation.vtkInformation_Set_132(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3, value4, value5, value6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_133(HandleRef pThis, HandleRef key, string value, int idx);

		public void Set(vtkInformationStringVectorKey key, string value, int idx)
		{
			vtkInformation.vtkInformation_Set_133(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, idx);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_134(HandleRef pThis, HandleRef key, IntPtr value, int length);

		public void Set(vtkInformationIntegerPointerKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_134(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_135(HandleRef pThis, HandleRef key, uint value);

		public void Set(vtkInformationUnsignedLongKey key, uint value)
		{
			vtkInformation.vtkInformation_Set_135(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_136(HandleRef pThis, HandleRef key, IntPtr value, int length);

		public void Set(vtkInformationDoubleVectorKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_136(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_137(HandleRef pThis, HandleRef key, double value1, double value2, double value3);

		public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3)
		{
			vtkInformation.vtkInformation_Set_137(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_Set_138(HandleRef pThis, HandleRef key, double value1, double value2, double value3, double value4, double value5, double value6);

		public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3, double value4, double value5, double value6)
		{
			vtkInformation.vtkInformation_Set_138(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3, value4, value5, value6);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformation_SetRequest_139(HandleRef pThis, HandleRef request);

		public void SetRequest(vtkInformationRequestKey request)
		{
			vtkInformation.vtkInformation_SetRequest_139(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis());
		}
	}
}
